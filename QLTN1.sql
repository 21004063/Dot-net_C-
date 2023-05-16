/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     05/04/2023 21:37:04                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADMINACCOUNTS') and o.name = 'FK_ADMINACC_ADCOTAIKH_ADMIN')
alter table ADMINACCOUNTS
   drop constraint FK_ADMINACC_ADCOTAIKH_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CAUHOI') and o.name = 'FK_CAUHOI_CAUHOITRO_MONHOC')
alter table CAUHOI
   drop constraint FK_CAUHOI_CAUHOITRO_MONHOC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('COCAUHOI') and o.name = 'FK_COCAUHOI_COCAUHOI_CAUHOI')
alter table COCAUHOI
   drop constraint FK_COCAUHOI_COCAUHOI_CAUHOI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('COCAUHOI') and o.name = 'FK_COCAUHOI_COCAUHOI2_DETHI')
alter table COCAUHOI
   drop constraint FK_COCAUHOI_COCAUHOI2_DETHI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETHI') and o.name = 'FK_DETHI_GVTAODE_GIANGVIE')
alter table DETHI
   drop constraint FK_DETHI_GVTAODE_GIANGVIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DETHI') and o.name = 'FK_DETHI_THUOCKITH_KITHI')
alter table DETHI
   drop constraint FK_DETHI_THUOCKITH_KITHI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GIANGVIEN') and o.name = 'FK_GIANGVIE_GVTHUOCKH_KHOA')
alter table GIANGVIEN
   drop constraint FK_GIANGVIE_GVTHUOCKH_KHOA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GVACCOUNTS') and o.name = 'FK_GVACCOUN_GVCOTAIKH_GIANGVIE')
alter table GVACCOUNTS
   drop constraint FK_GVACCOUN_GVCOTAIKH_GIANGVIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOP') and o.name = 'FK_LOP_LOPTHUOCK_KHOA')
alter table LOP
   drop constraint FK_LOP_LOPTHUOCK_KHOA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MONHOC') and o.name = 'FK_MONHOC_MONTHUOCK_KHOA')
alter table MONHOC
   drop constraint FK_MONHOC_MONTHUOCK_KHOA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SINHVIEN') and o.name = 'FK_SINHVIEN_SVTHUOCLO_LOP')
alter table SINHVIEN
   drop constraint FK_SINHVIEN_SVTHUOCLO_LOP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SVACCOUNTS') and o.name = 'FK_SVACCOUN_SVCOTAIKH_SINHVIEN')
alter table SVACCOUNTS
   drop constraint FK_SVACCOUN_SVCOTAIKH_SINHVIEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ADMINACCOUNTS')
            and   name  = 'ADCOTAIKHOAN_FK'
            and   indid > 0
            and   indid < 255)
   drop index ADMINACCOUNTS.ADCOTAIKHOAN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMINACCOUNTS')
            and   type = 'U')
   drop table ADMINACCOUNTS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CAUHOI')
            and   name  = 'CAUHOITRONG_FK'
            and   indid > 0
            and   indid < 255)
   drop index CAUHOI.CAUHOITRONG_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CAUHOI')
            and   type = 'U')
   drop table CAUHOI
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('COCAUHOI')
            and   name  = 'COCAUHOI2_FK'
            and   indid > 0
            and   indid < 255)
   drop index COCAUHOI.COCAUHOI2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('COCAUHOI')
            and   name  = 'COCAUHOI_FK'
            and   indid > 0
            and   indid < 255)
   drop index COCAUHOI.COCAUHOI_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COCAUHOI')
            and   type = 'U')
   drop table COCAUHOI
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETHI')
            and   name  = 'GVTAODE_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETHI.GVTAODE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DETHI')
            and   name  = 'THUOCKITHI_FK'
            and   indid > 0
            and   indid < 255)
   drop index DETHI.THUOCKITHI_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DETHI')
            and   type = 'U')
   drop table DETHI
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GIANGVIEN')
            and   name  = 'GVTHUOCKHOA_FK'
            and   indid > 0
            and   indid < 255)
   drop index GIANGVIEN.GVTHUOCKHOA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GIANGVIEN')
            and   type = 'U')
   drop table GIANGVIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GVACCOUNTS')
            and   name  = 'GVCOTAIKHOAN_FK'
            and   indid > 0
            and   indid < 255)
   drop index GVACCOUNTS.GVCOTAIKHOAN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GVACCOUNTS')
            and   type = 'U')
   drop table GVACCOUNTS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHOA')
            and   type = 'U')
   drop table KHOA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KITHI')
            and   type = 'U')
   drop table KITHI
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOP')
            and   name  = 'LOPTHUOCKHOA_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOP.LOPTHUOCKHOA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOP')
            and   type = 'U')
   drop table LOP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MONHOC')
            and   name  = 'MONTHUOCKHOA_FK'
            and   indid > 0
            and   indid < 255)
   drop index MONHOC.MONTHUOCKHOA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MONHOC')
            and   type = 'U')
   drop table MONHOC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SINHVIEN')
            and   name  = 'SVTHUOCLOP_FK'
            and   indid > 0
            and   indid < 255)
   drop index SINHVIEN.SVTHUOCLOP_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SINHVIEN')
            and   type = 'U')
   drop table SINHVIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SVACCOUNTS')
            and   name  = 'SVCOTAIKHOAN_FK'
            and   indid > 0
            and   indid < 255)
   drop index SVACCOUNTS.SVCOTAIKHOAN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SVACCOUNTS')
            and   type = 'U')
   drop table SVACCOUNTS
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   MAADMIN              varchar(10)          not null,
   TENADMIN             varchar(50)          null,
   GIOITINHADMIN        bit                  null,
   constraint PK_ADMIN primary key nonclustered (MAADMIN)
)
go

/*==============================================================*/
/* Table: ADMINACCOUNTS                                         */
/*==============================================================*/
create table ADMINACCOUNTS (
   UIDAD                varchar(50)          not null,
   MAADMIN              varchar(10)          not null,
   PASSWORDAD           varchar(50)          null,
   ENABLEAD             bit                  null,
   constraint PK_ADMINACCOUNTS primary key nonclustered (UIDAD)
)
go

/*==============================================================*/
/* Index: ADCOTAIKHOAN_FK                                       */
/*==============================================================*/
create index ADCOTAIKHOAN_FK on ADMINACCOUNTS (
MAADMIN ASC
)
go

/*==============================================================*/
/* Table: CAUHOI                                                */
/*==============================================================*/
create table CAUHOI (
   MACAUHOI             varchar(10)          not null,
   MAMON                varchar(10)          not null,
   NOIDUNGCAUHOI        varchar(1000)        null,
   PHUONGANA            varchar(1000)        null,
   PHUONGANB            varchar(1000)        null,
   PHUONGANC            varchar(1000)        null,
   PHUONGAND            varchar(1000)        null,
   MUCDO                tinyint              null,
   DAPAN                varchar(10)          null,
   constraint PK_CAUHOI primary key nonclustered (MACAUHOI)
)
go

/*==============================================================*/
/* Index: CAUHOITRONG_FK                                        */
/*==============================================================*/
create index CAUHOITRONG_FK on CAUHOI (
MAMON ASC
)
go

/*==============================================================*/
/* Table: COCAUHOI                                              */
/*==============================================================*/
create table COCAUHOI (
   MACAUHOI             varchar(10)          not null,
   MADETHI              varchar(10)          not null,
   ABC                  varchar(20)          null,
   constraint PK_COCAUHOI primary key (MACAUHOI, MADETHI)
)
go

/*==============================================================*/
/* Index: COCAUHOI_FK                                           */
/*==============================================================*/
create index COCAUHOI_FK on COCAUHOI (
MACAUHOI ASC
)
go

/*==============================================================*/
/* Index: COCAUHOI2_FK                                          */
/*==============================================================*/
create index COCAUHOI2_FK on COCAUHOI (
MADETHI ASC
)
go

/*==============================================================*/
/* Table: DETHI                                                 */
/*==============================================================*/
create table DETHI (
   MADETHI              varchar(10)          not null,
   MAKITHI              varchar(10)          not null,
   MSSV2                varchar(10)          not null,
   NGAYTAO              datetime             null,
   SOLUONGCAUHOI        int                  null,
   constraint PK_DETHI primary key nonclustered (MADETHI)
)
go

/*==============================================================*/
/* Index: THUOCKITHI_FK                                         */
/*==============================================================*/
create index THUOCKITHI_FK on DETHI (
MAKITHI ASC
)
go

/*==============================================================*/
/* Index: GVTAODE_FK                                            */
/*==============================================================*/
create index GVTAODE_FK on DETHI (
MSSV2 ASC
)
go

/*==============================================================*/
/* Table: GIANGVIEN                                             */
/*==============================================================*/
create table GIANGVIEN (
   MSSV2                varchar(10)          not null,
   MAKHOA               varchar(10)          not null,
   HOTENGV              varchar(100)         null,
   GIOITINHGV           bit                  null,
   NGAYSINHGV           datetime             null,
   CHUCVU               varchar(50)          null,
   constraint PK_GIANGVIEN primary key nonclustered (MSSV2)
)
go

/*==============================================================*/
/* Index: GVTHUOCKHOA_FK                                        */
/*==============================================================*/
create index GVTHUOCKHOA_FK on GIANGVIEN (
MAKHOA ASC
)
go

/*==============================================================*/
/* Table: GVACCOUNTS                                            */
/*==============================================================*/
create table GVACCOUNTS (
   UIDGV                varchar(50)          not null,
   MSSV2                varchar(10)          not null,
   PASSWORDGV           varchar(50)          null,
   ENABLEGV             bit                  null,
   constraint PK_GVACCOUNTS primary key nonclustered (UIDGV)
)
go

/*==============================================================*/
/* Index: GVCOTAIKHOAN_FK                                       */
/*==============================================================*/
create index GVCOTAIKHOAN_FK on GVACCOUNTS (
MSSV2 ASC
)
go

/*==============================================================*/
/* Table: KHOA                                                  */
/*==============================================================*/
create table KHOA (
   MAKHOA               varchar(10)          not null,
   TENKHOA              varchar(50)          null,
   constraint PK_KHOA primary key nonclustered (MAKHOA)
)
go

/*==============================================================*/
/* Table: KITHI                                                 */
/*==============================================================*/
create table KITHI (
   MAKITHI              varchar(10)          not null,
   TENKITHI             varchar(50)          null,
   NAMHOC               varchar(10)          null,
   HOCKI                varchar(10)          null,
   constraint PK_KITHI primary key nonclustered (MAKITHI)
)
go

/*==============================================================*/
/* Table: LOP                                                   */
/*==============================================================*/
create table LOP (
   MALOP                varchar(10)          not null,
   MAKHOA               varchar(10)          not null,
   TENLOP               varchar(50)          null,
   NAMNHAPHOC           varchar(4)           null,
   SOLUONGSV            varchar(10)          null,
   constraint PK_LOP primary key nonclustered (MALOP)
)
go

/*==============================================================*/
/* Index: LOPTHUOCKHOA_FK                                       */
/*==============================================================*/
create index LOPTHUOCKHOA_FK on LOP (
MAKHOA ASC
)
go

/*==============================================================*/
/* Table: MONHOC                                                */
/*==============================================================*/
create table MONHOC (
   MAMON                varchar(10)          not null,
   MAKHOA               varchar(10)          not null,
   TENMON               varchar(50)          null,
   SOTINCHI             tinyint              null,
   SOTINCHITH           tinyint              null,
   constraint PK_MONHOC primary key nonclustered (MAMON)
)
go

/*==============================================================*/
/* Index: MONTHUOCKHOA_FK                                       */
/*==============================================================*/
create index MONTHUOCKHOA_FK on MONHOC (
MAKHOA ASC
)
go

/*==============================================================*/
/* Table: SINHVIEN                                              */
/*==============================================================*/
create table SINHVIEN (
   MSSV                 varchar(10)          not null,
   MALOP                varchar(10)          not null,
   HOTENGV              varchar(100)         null,
   GIOITINHGV           bit                  null,
   NGAYSINHGV           datetime             null,
   constraint PK_SINHVIEN primary key nonclustered (MSSV)
)
go

/*==============================================================*/
/* Index: SVTHUOCLOP_FK                                         */
/*==============================================================*/
create index SVTHUOCLOP_FK on SINHVIEN (
MALOP ASC
)
go

/*==============================================================*/
/* Table: SVACCOUNTS                                            */
/*==============================================================*/
create table SVACCOUNTS (
   UIDSV                varchar(50)          not null,
   MSSV                 varchar(10)          not null,
   PASSWORDSV           varchar(50)          null,
   ENABLESV             bit                  null,
   constraint PK_SVACCOUNTS primary key nonclustered (UIDSV)
)
go

/*==============================================================*/
/* Index: SVCOTAIKHOAN_FK                                       */
/*==============================================================*/
create index SVCOTAIKHOAN_FK on SVACCOUNTS (
MSSV ASC
)
go

alter table ADMINACCOUNTS
   add constraint FK_ADMINACC_ADCOTAIKH_ADMIN foreign key (MAADMIN)
      references ADMIN (MAADMIN)
go

alter table CAUHOI
   add constraint FK_CAUHOI_CAUHOITRO_MONHOC foreign key (MAMON)
      references MONHOC (MAMON)
go

alter table COCAUHOI
   add constraint FK_COCAUHOI_COCAUHOI_CAUHOI foreign key (MACAUHOI)
      references CAUHOI (MACAUHOI)
go

alter table COCAUHOI
   add constraint FK_COCAUHOI_COCAUHOI2_DETHI foreign key (MADETHI)
      references DETHI (MADETHI)
go

alter table DETHI
   add constraint FK_DETHI_GVTAODE_GIANGVIE foreign key (MSSV2)
      references GIANGVIEN (MSSV2)
go

alter table DETHI
   add constraint FK_DETHI_THUOCKITH_KITHI foreign key (MAKITHI)
      references KITHI (MAKITHI)
go

alter table GIANGVIEN
   add constraint FK_GIANGVIE_GVTHUOCKH_KHOA foreign key (MAKHOA)
      references KHOA (MAKHOA)
go

alter table GVACCOUNTS
   add constraint FK_GVACCOUN_GVCOTAIKH_GIANGVIE foreign key (MSSV2)
      references GIANGVIEN (MSSV2)
go

alter table LOP
   add constraint FK_LOP_LOPTHUOCK_KHOA foreign key (MAKHOA)
      references KHOA (MAKHOA)
go

alter table MONHOC
   add constraint FK_MONHOC_MONTHUOCK_KHOA foreign key (MAKHOA)
      references KHOA (MAKHOA)
go

alter table SINHVIEN
   add constraint FK_SINHVIEN_SVTHUOCLO_LOP foreign key (MALOP)
      references LOP (MALOP)
go

alter table SVACCOUNTS
   add constraint FK_SVACCOUN_SVCOTAIKH_SINHVIEN foreign key (MSSV)
      references SINHVIEN (MSSV)
go

