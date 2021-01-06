SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 208 (class 1255 OID 16463)
-- Name: sp_create_user(text, text, text, text, integer); Type: PROCEDURE; Schema: public; Owner: postgres
--

CREATE PROCEDURE public.sp_create_user(first_names text, last_names text, phone text, address text, city integer)
    LANGUAGE plpgsql
    AS $$
begin    
    insert into usr_user(first_names_usr, last_names_usr, phone_usr, address_usr, city_usr)     
    values (first_names, last_names, phone, address, city);
    commit;
end;$$;


ALTER PROCEDURE public.sp_create_user(first_names text, last_names text, phone text, address text, city integer) OWNER TO postgres;

--
-- TOC entry 221 (class 1255 OID 16460)
-- Name: sp_query_locations(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.sp_query_locations() RETURNS TABLE(id_cty integer, name_cty text, id_ste integer, name_ste text, id_cit integer, name_cit text)
    LANGUAGE sql
    AS $$
   	select id_cty, 
	  	   name_cty,
	  	   id_ste,
	  	   name_ste,
	  	   id_cit,
	  	   name_cit 
	from par_country cty
	inner join par_state ste
		on cty.id_cty = ste.Country_ste
	inner join par_city cit
		on ste.id_ste = cit.state_cit;
$$;


ALTER FUNCTION public.sp_query_locations() OWNER TO postgres;

--
-- TOC entry 220 (class 1255 OID 16466)
-- Name: sp_query_users(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.sp_query_users(id integer) RETURNS TABLE(idusuario integer, nombres text, apellidos text, telefono text, direccion text, pais text, departamento text, ciudad text)
    LANGUAGE sql
    AS $$



select id_usr as IdUsuario,
	   first_names_usr as Nombres,
	   last_names_usr as Apellidos,
	   phone_usr as Telefono,
	   address_usr as Direccion,
	   name_cty as Pais,
	   name_ste as Departamento,
	   name_cit as Ciudad
from usr_user usr
	inner join par_city cit
		on usr.city_usr = cit.id_cit
	inner join par_state ste
		on cit.state_cit = ste.id_ste
	inner join par_country cty
		on ste.country_ste = id_cty
where usr.id_usr = CASE 
						WHEN id = 0 
            			THEN usr.id_usr 
            			ELSE id 
				    END;
$$;


ALTER FUNCTION public.sp_query_users(id integer) OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 207 (class 1259 OID 16431)
-- Name: par_city; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.par_city (
    id_cit integer NOT NULL,
    name_cit character varying(30) NOT NULL,
    state_cit integer NOT NULL
);


ALTER TABLE public.par_city OWNER TO postgres;

--
-- TOC entry 3025 (class 0 OID 0)
-- Dependencies: 207
-- Name: TABLE par_city; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.par_city IS 'List of cities';


--
-- TOC entry 3026 (class 0 OID 0)
-- Dependencies: 207
-- Name: COLUMN par_city.id_cit; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.par_city.id_cit IS 'City identificaction';


--
-- TOC entry 3027 (class 0 OID 0)
-- Dependencies: 207
-- Name: COLUMN par_city.name_cit; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.par_city.name_cit IS 'City name';


--
-- TOC entry 3028 (class 0 OID 0)
-- Dependencies: 207
-- Name: COLUMN par_city.state_cit; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.par_city.state_cit IS 'Foreign key to the states table';


--
-- TOC entry 203 (class 1259 OID 16417)
-- Name: par_country; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.par_country (
    id_cty integer NOT NULL,
    name_cty character varying(30) NOT NULL
);


ALTER TABLE public.par_country OWNER TO postgres;

--
-- TOC entry 3029 (class 0 OID 0)
-- Dependencies: 203
-- Name: TABLE par_country; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.par_country IS 'List of countries for the user';


--
-- TOC entry 3030 (class 0 OID 0)
-- Dependencies: 203
-- Name: COLUMN par_country.id_cty; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.par_country.id_cty IS 'Country identification';

--
-- TOC entry 205 (class 1259 OID 16424)
-- Name: par_state; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.par_state (
    id_ste integer NOT NULL,
    name_ste character varying(30) NOT NULL,
    country_ste integer NOT NULL
);


ALTER TABLE public.par_state OWNER TO postgres;

--
-- TOC entry 3031 (class 0 OID 0)
-- Dependencies: 205
-- Name: TABLE par_state; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.par_state IS 'List of states for the user';


--
-- TOC entry 3032 (class 0 OID 0)
-- Dependencies: 205
-- Name: COLUMN par_state.id_ste; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.par_state.id_ste IS 'State identification.';


--
-- TOC entry 3033 (class 0 OID 0)
-- Dependencies: 205
-- Name: COLUMN par_state.country_ste; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.par_state.country_ste IS 'Foreign key with the table of countries';


--
-- TOC entry 200 (class 1259 OID 16403)
-- Name: usr_user; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.usr_user (
    id_usr integer NOT NULL,
    first_names_usr character varying(50) NOT NULL,
    last_names_usr character varying(50) NOT NULL,
    phone_usr character varying(15) NOT NULL,
    address_usr character varying(80) NOT NULL,
    city_usr integer NOT NULL
);


ALTER TABLE public.usr_user OWNER TO postgres;

--
-- TOC entry 3034 (class 0 OID 0)
-- Dependencies: 200
-- Name: TABLE usr_user; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.usr_user IS 'Registration of the name, address and telephone number of the user.
In addition, the foreign key to the table is recorded, which is related to the state and this to the country.';


--
-- TOC entry 3035 (class 0 OID 0)
-- Dependencies: 200
-- Name: COLUMN usr_user.id_usr; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.usr_user.id_usr IS 'Unique user identification';


--
-- TOC entry 3036 (class 0 OID 0)
-- Dependencies: 200
-- Name: COLUMN usr_user.first_names_usr; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.usr_user.first_names_usr IS 'User''s first and middle name';


--
-- TOC entry 3037 (class 0 OID 0)
-- Dependencies: 200
-- Name: COLUMN usr_user.last_names_usr; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.usr_user.last_names_usr IS 'User last names';


--
-- TOC entry 3038 (class 0 OID 0)
-- Dependencies: 200
-- Name: COLUMN usr_user.phone_usr; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.usr_user.phone_usr IS 'User phone number.';


--
-- TOC entry 3039 (class 0 OID 0)
-- Dependencies: 200
-- Name: COLUMN usr_user.address_usr; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.usr_user.address_usr IS 'User address';


--
-- TOC entry 3040 (class 0 OID 0)
-- Dependencies: 200
-- Name: COLUMN usr_user.city_usr; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN public.usr_user.city_usr IS 'Foreign key of the user''s city table';


--
-- TOC entry 201 (class 1259 OID 16408)
-- Name: usr_users_Id_user_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.usr_user ALTER COLUMN id_usr ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."usr_users_Id_user_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);

--
-- TOC entry 3044 (class 0 OID 0)
-- Dependencies: 201
-- Name: usr_users_Id_user_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."usr_users_Id_user_seq"', 10, true);

--
-- TOC entry 2878 (class 2606 OID 16435)
-- Name: par_city par_cities_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.par_city
    ADD CONSTRAINT par_cities_pkey PRIMARY KEY (id_cit);


--
-- TOC entry 2874 (class 2606 OID 16421)
-- Name: par_country par_countrys_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.par_country
    ADD CONSTRAINT par_countrys_pkey PRIMARY KEY (id_cty);


--
-- TOC entry 2876 (class 2606 OID 16428)
-- Name: par_state par_states_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.par_state
    ADD CONSTRAINT par_states_pkey PRIMARY KEY (id_ste);


--
-- TOC entry 2872 (class 2606 OID 16414)
-- Name: usr_user usr_users_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usr_user
    ADD CONSTRAINT usr_users_pkey PRIMARY KEY (id_usr);


--
-- TOC entry 2881 (class 2606 OID 16436)
-- Name: par_city fk_state_city; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.par_city
    ADD CONSTRAINT fk_state_city FOREIGN KEY (state_cit) REFERENCES public.par_state(id_ste) NOT VALID;


--
-- TOC entry 2880 (class 2606 OID 16441)
-- Name: par_state fk_state_country; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.par_state
    ADD CONSTRAINT fk_state_country FOREIGN KEY (country_ste) REFERENCES public.par_country(id_cty) NOT VALID;


--
-- TOC entry 2879 (class 2606 OID 16446)
-- Name: usr_user fk_user_city; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usr_user
    ADD CONSTRAINT fk_user_city FOREIGN KEY (city_usr) REFERENCES public.par_city(id_cit) NOT VALID;


--
-- PostgreSQL database dump complete
--

