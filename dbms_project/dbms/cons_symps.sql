alter table symptoms
add constraint unique_sympDis unique(sy_name,sy_id)
