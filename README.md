# land_forcesAPI(Asp.Net Core web api CRUD)
English:
Hello, you need to do the following 3 steps to run the project locally on your own computer.
1. Open the appsettings.json file and add the mssql connection in it as follows.
 "ConnectionStrings": {
    "DatabaseConnection": "Server=(to this area "your_mssql_server_Name"); Database=DatabaseNameDb;
 Trusted_Connection=True"
  },

2. Open Manager Console(View > Other Window > Package Manager Consele)
 Write: Add-migration mig2 and press enter 

3. Open Manager Console
 Write:update-database and press enter 
#And run the API
Thank you for your interest and concern.

Türkçe:
Merhaba projeyi local de kendi bilgisayarınızda çalıştırmak için aşağıdaki 3 adımı yapmanız gerekmektedir.
1. appsettings.json dosyasını açın ve içine aşağıdaki gibi mssql bağlantısını ekleyiniz.
"ConnectionStrings": {
    "DatabaseConnection": "Server=(bu alana "" içinde localhost veri tabanı uzantısı yazınız); Database=Camlica_camlica_projectDB;
 Trusted_Connection=True"
  },
  
2.Package Manager Console açın(View > Other Window > Package Manager Consele)
Add-migration mig2 yazıp enter a basın.

3.Package Manager Console açın
update-database yazıp enter a basın.
Ve API'yi çalıştırın.
İlginiz ve alakanız için  teşekkür ederim.
