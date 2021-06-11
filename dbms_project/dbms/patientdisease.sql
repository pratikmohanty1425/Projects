create table PatientDisease
(
pd_id bigint not null identity primary key,
pd_appointmentId bigint not null foreign key references patientAppointment(pa_id) on delete cascade on update cascade,
pd_diseaseID int not null foreign key references diseases(d_id) on delete no action on update no action
)