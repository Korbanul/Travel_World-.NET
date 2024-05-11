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

Database Schema: image
![image](https://github.com/Korbanul/Travel_World-.NET/assets/168090744/367bf1bf-35fd-4603-bdc1-6bac6c4d9562)
ER DIAGRAM:
![image](https://github.com/Korbanul/Travel_World-.NET/assets/168090744/0ad31cf9-bd7b-43e1-86da-623405d522a9)

Login Page:
![image](https://github.com/Korbanul/Travel_World-.NET/assets/168090744/492f7573-9bcb-4e9d-9d86-512f9af8205a)


Customer SignUP:
 ![image](https://github.com/Korbanul/Travel_World-.NET/assets/168090744/6f8a8253-922a-4d7b-8a65-213f63951a83)


Agencies Sign Up:
 ![image](https://github.com/Korbanul/Travel_World-.NET/assets/168090744/f8755a5f-d6ac-4cc0-916e-10758297aff4)


Customer Log In:
 ![Customer home](https://github.com/Korbanul/Travel_World-.NET/assets/168090744/9a8bd704-abc3-4011-935c-f426e82fcfa8)



Customer Offer Packages:
![Screenshot 2024-05-10 194612](https://github.com/Korbanul/Travel_World-.NET/assets/168090744/ff942be1-9f21-4192-bd3d-b3d045df913d)


Payment Page
![image](https://github.com/Korbanul/Travel_World-.NET/assets/168090744/d7c19e8a-a9ad-4178-819e-216dcd7b3eeb)

Customer Account:
![image](https://github.com/Korbanul/Travel_World-.NET/assets/168090744/142c9fae-949d-4557-aa35-b402924b4c75)


Agencies Home:
![Screenshot 2024-05-10 200341](https://github.com/Korbanul/Travel_World-.NET/assets/168090744/74ebc9a7-695b-4bae-b139-c40be4487769)

Agencies Add Packages:
![image](https://github.com/Korbanul/Travel_World-.NET/assets/168090744/713c7c8a-9bd5-4a55-a18c-afa5f141d3bd)


Agencies Bid option:
![Screenshot 2024-05-10 200425](https://github.com/Korbanul/Travel_World-.NET/assets/168090744/b3ab5b07-d190-4249-a172-80afa677620d)


Agencies Account:
 ![image](https://github.com/Korbanul/Travel_World-.NET/assets/168090744/e7871bca-e0aa-4757-9e61-140a18bc6490)


Admin Login:
![Screenshot 2024-05-10 200639](https://github.com/Korbanul/Travel_World-.NET/assets/168090744/9b0a1325-1579-4804-ba0e-7c1fd72cb44f)

