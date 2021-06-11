create procedure st_getTests
as
select t.t_id as 'ID',
t.t_name as 'Test',
t.t_price as 'Price',
t.t_precautions as 'Precautions'
from tests t order by t.t_name asc