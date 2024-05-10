# OnlineSellingPhone_DatabaseCoding_BigAssignment
Using .NetFramework version 4.6, and EntityFramework version 6.4.4 are required to run the project.

How to run the project?
# **1. Install Entity Framework 6.4.4**
In VisualStudio **Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution...**
![image](https://github.com/DNhat283N/OnlineSellingPhone_DatabaseCoding_BigAssignment/assets/112379980/7cffb516-d988-4e4b-a078-ec8dc94b447d)
In the **Browse** tab search _entity_ in the Search textbox.
Click on **Entity Framework**, tick on checkbox of **Project**, choose version 6.4.4 and click **Install** 
![image](https://github.com/DNhat283N/OnlineSellingPhone_DatabaseCoding_BigAssignment/assets/112379980/c3041886-0b55-433c-ac72-d986888fa006)
My solution installed Entity Framework so it will be **Uninstall** instead of **Install**  
# **2. Open Package Manager Console**
In VisualStudio **Tools -> NuGet Package Manager -> Package Manger Console**   
# **3. Build Migration Folder**
In **Package Manager Console** write these commands sequence:enable-migrations, add-migration Migrations and update-database
**Note: Build in DataLayer**
![image](https://github.com/DNhat283N/OnlineSellingPhone_DatabaseCoding_BigAssignment/assets/112379980/53bef44a-caf9-4163-a78b-d64cded9d146)
# **4. Add data to Database**
 Open your SSMS and insert data into the database with the name OnlineSellingPhone    
# **5. Run project**
