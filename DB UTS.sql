PGDMP  /                
    |            UTS_PBO    16.2    16.2     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    17797    UTS_PBO    DATABASE     �   CREATE DATABASE "UTS_PBO" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_Indonesia.1252';
    DROP DATABASE "UTS_PBO";
                postgres    false            �          0    17799    akun 
   TABLE DATA           7   COPY public.akun (id_, username, password) FROM stdin;
    public          postgres    false    216   X       �          0    17808    kontak 
   TABLE DATA           :   COPY public.kontak (id_, no_telp, namakontak) FROM stdin;
    public          postgres    false    218   �       �           0    0    akun_id__seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.akun_id__seq', 1, false);
          public          postgres    false    215            �           0    0    kontak_id__seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.kontak_id__seq', 1, false);
          public          postgres    false    217            �   0   x�3�̨L)J,I�L���,����2�L,H�N��̫L,)M����� ��      �   ;   x�3�4�04775��040������M��2	���pf�'�dg��p��qqq I�     