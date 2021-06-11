create table PatientSymptoms
(
ps_id bigint not null identity primary key,
ps_appointmentID bigint not null foreign key references patientAppointment(pa_id) on delete cascade on update cascade,
ps_symptomID bigint not null foreign key references symptoms(sy_id) on delete no action on update no action
)