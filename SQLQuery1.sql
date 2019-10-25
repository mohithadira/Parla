use HospitalManagementSystem
create table doctor(
DoctorId varchar(10) Primary Key,
DoctorName varchar(50),
Dept varchar(50)
)

create table Patient(
PatientId varchar(10) Primary Key,
PatientName varchar(50),
PatientAge int,
PatientWeight int,
PatientGender char,
PatientAddress varchar(150),
PatientContact varchar(10),
PatientDisease varchar(50),
DoctorId varchar(10) foreign key references doctor(DoctorID),
PatientType char,
)

create table Lab(
LabId varchar(10) Primary Key,
PatientId varchar(10) foreign key references Patient(PatientId),
DoctorId varchar(10)  foreign key references doctor(DoctorId),
TestDate Date,
TestType varchar(50),
PatientType varchar(20)
)

create table Treatment(
TreatmentId int primary key,
PatientId varchar(10) foreign key references Patient(PatientId),
LabId varchar(10) foreign key references Lab(LabId) null,
--in patient
RoomNo varchar(5) null,
AdmissionDate date null,
DischargeDate date null,
AmountPerDay decimal(10,2) null,
--out patient
TreatmentDate date null,
)

create table Billing(
BillNo varchar(10) primary key,
PatientId varchar(10) foreign key references Patient(PatientId),
DoctorId varchar(10) foreign key references doctor(DoctorId),
DoctorFees decimal(10,2),
RoomCharges decimal(10,2),
TotalDays int,
OperationCharges decimal(10,2),
MedicineFees decimal(10,2),
LabFees decimal(10,2),
TotalAmount decimal(10,2)
)
