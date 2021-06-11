create table PatientPrescription
(
pip_id bigint not null identity primary key,
pip_appointmentID bigint not null foreign key references patientAppointment(pa_id) on delete cascade on update cascade,
pip_medicineID int not null foreign key references medicine(m_id) on delete no action on update no action,
pip_dosageID tinyint not null,
pip_others varchar(100)
)