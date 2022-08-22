use PentionerDetails;
insert into dbo.Pensioners (Aadhar,Name,DOB,PAN,SalaryEarned,Allowances,PensionType,BankName,AccountNumber,BankType)
values
('871401017777', 'Abhinav Pathak','20120618 10:34:09 AM' , 'EIIPP0777E', 26000.00, 8525.00, 0 , 'KOTAK', '11331313122121', 1),
('871401014562', 'Abhinav Pathak','20120618 10:34:09 AM' , 'EIIPP0777E', 28000.00, 8524.00, 1 , 'KOTAK', '11331313122121', 1),
('871404562747', 'Abhinav Pathak','20120618 10:34:09 AM' , 'EIIPP0777E', 30000.00, 5000.00, 0 , 'KOTAK', '11331313122121', 0);


select * from dbo.Pensioners;