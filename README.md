# Travel_World-.NET
CASE STUDY: In a comprehensive travel management system, users have the ability to select a package based on a variety of criteria, tailoring their experience to their preferences. Additionally, users can personalize their chosen package and even propose their customized itinerary. Each user possesses pertinent information such as their name, ID, email, phone number, address, and birthdate.

Every package within the system is uniquely identified by its ID and encompasses details such as the destination country, hotel name, pricing, capacity, and duration of stay. Multiple agencies participate within the system, each capable of crafting and presenting diverse packages. However, each package is exclusively associated with a single agency. Agencies are characterized by their ID, name, address, and contact number. Agencies can bid for a package offered by the user.

The system operates under the oversight of an administrator who holds an ID and password, ensuring the integrity and security of the platform.

FUNCTIONALITIES:

After Login a user can choose any package.
Can filter or search packages as they want.
The user can also make his own package and make it available for agencies to bid.
There is an account section where user can see his/her all details and update them.
The user can make payment.
Agencies can offer packages with all the details.
They can track the packages, how many packages are published, how many sold and status of that.
They can bid for a package offered by the user.
Can receive payment from user.
An Admin can see how many users have and all there details. 11.Also Agencies details and packages.
Admin can delete an user or agencies or packages for inappropriate activities.
DATABASE SCHEMA: SQL Query: create database Travel_World;

create table Package ( p_id int, A_id int, c_id int, p_country varchar (26), p_hotel varchar(26), p_price int, p_capacity int, p_duration int ) create table AgenciesDetails(

Agencies_Name varchar(50), Email varchar(26), Phone int, Address Varchar(60), password Varchar(10), p_id int )

create table Admin( Uname varchar(26), Password varchar(26)

)

create table UserDetails(

firstName varchar(26), Secondname varchar(26), email varchar(26), Address varchar(26), password varchar(26), p_id int , c_id int , Username varchar(26), Phone int(11), picloc varchar (26) )

select * from Admin; select * from UserDetails; select * from AgenciesDetails; select * from Package;

insert into Admin(Uname,Password) values('shanto','s')

ER DIAGRAM: image
![image](https://github.com/Korbanul/Travel_World/assets/168090744/9150fa00-76a4-47ad-9408-aec9526fe23d)
Login Page:
![image](https://github.com/Korbanul/Travel_World/assets/168090744/7cbb6bdc-a54e-4a29-8507-d2a7f53684dc)

Customer SignUP:
 ![image](https://github.com/Korbanul/Travel_World/assets/168090744/197d0118-7f8b-4dac-8663-db7a63661f85)

Agencies Sign Up:
 ![image](https://github.com/Korbanul/Travel_World/assets/168090744/3eb009e3-962b-414b-85c1-7947e2434553)

Customer Log In:
 
![Customer home](https://github.com/Korbanul/Travel_World/assets/168090744/42082ac4-9b98-44df-82da-17336966060e)

Customer Offer Packages:
![Screenshot 2024-05-10 194612](https://github.com/Korbanul/Travel_World/assets/168090744/92415d72-50cb-4ac8-af1d-1944edd38819)

Payment Page
![PaymentPage](https://github.com/Korbanul/Travel_World/assets/168090744/4b8bea7e-e802-448a-8c99-7dc75ca42bb2)

Customer Account:
 ![Customer Account](https://github.com/Korbanul/Travel_World/assets/168090744/a83a1411-3dad-4c35-898b-6be68c9e01c2)

Agencies Home:
 ![image](https://github.com/Korbanul/Travel_World/assets/168090744/7449bea1-29fd-41f5-8de3-434cc3afcf2a)

Agencies Add Packages:
![Add package](https://github.com/Korbanul/Travel_World/assets/168090744/26120a8b-eea9-4730-b57b-eaa4ee20f36c)

Agencies Bid option:
![image](https://github.com/Korbanul/Travel_World/assets/168090744/0987d74e-e2d6-4ea0-9df1-2a1be8029d8b)

Agencies Account:
 ![Agencies Account](https://github.com/Korbanul/Travel_World/assets/168090744/05fe4ed6-66b6-4309-acc0-71f557491c96)


Admin Login:
 ![image](https://github.com/Korbanul/Travel_World/assets/168090744/012bd301-30c1-483b-a52b-ce532436a65d)
