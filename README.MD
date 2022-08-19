# AnimalShelter.Solution

#### By _**Joseph Jack**_  

#### _Animal Shelter is an API application that is locally hosted. Built with C#/.NET Core , in addition the app utilizes JWT token authorization and authentication. Anonymous users have the ability to look up the full list of animals or one specifically by ID. Registered users are able to post new listings and or edit/delete._

---




---
## Setup and Installation Requirements
This Setup assumes you have GitBash and MySQL Workbench pre-installed. 
<br><small>If you do not have one or both installed, please begin with that setup below. 
<br>If you _do_ have both installed, move onto "initial setup".</small>

<details>
<summary><strong>GitBash and MySQL Workbench Setup</strong></summary>
<ol>
<li>https://git-scm.com/download/  
<li>Download Git and follow the setup wizard. 
<li>https://dev.mysql.com/downloads/workbench/     
<li>Download MySQL Workbench
<li>Follow the setup wizard & create a localhost server on port 3306.
<li>Keep track of your username and password, this will be used in the connection steps of "**SQL Workbench Configuration**"  
</details>
<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url: https://github.com/Josephwjack/AnimalShelter.Solution
<li>Open a terminal and navigate to your Desktop with <strong>cd</strong> command
<li>Run,   
<strong>$ git clone https://github.com/Josephwjack/AnimalShelter.Solution</strong>
<li>In the terminal, navigate into the root directory of the cloned project folder "AnimalShelter.Solution".
<li>Navigate to the projects root directory, "AnimalShelter".
<li>Move onto "SQL Workbench Configuration" instructions below to build the necessary database.
<br>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsetting.json file in the "AnimalShelter" directory  
   <pre>AnimalShelter.Solution
   └── AnimalShelter
    └── appsetting.json</pre>
<li> Insert the following code: <br>

<pre>{
  "AppSettings": {
    "Secret": "[YOUR-TOKEN-HERE]"
    },
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*Note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**Note: you must include your username in the code block section labeled "YOUR-USERNAME-HERE".</small><br>
<small>***Note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>

<li>In root directory of project folder "AnimalShelter", run  
<strong>$ dotnet ef migrations add restoreDatabase</strong>
<li>Then run <strong>$ dotnet ef database update</strong>

<ol> 
  <li>Open SQL Workbench.
  <li>Navigate to "animal_shelter" schema.
  <li>Click the drop down, select "Tables" drop down.
  <li>Verify the tables, you should see <strong>animals</strong> and <strong>user</strong>
  
</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>AnimalShelter.Solution
   └── <strong>AnimalShelter</strong></pre>

Run ```$ dotnet restore``` in the terminal.<br>
Run ```$ dotnet run``` in the terminal.
</details>
<hr/>
---

## _To Use Swagger UI_
Add the following to the url of your local host:
`` http://localhost:5000/``
* Swagger endpoint has been modified to just use simplest url.
1. Click on the **POST /api/Authenticate/register** dropdown under Authenticate.
2. Select "Try it out" , enter whichever username and password you prefer, proceed to click the blue **Execute** button.
3. If the call was successfull your account has been created, now you can login under the **POST** section right above register.
4. Enter credentials, login, and you will recieve a bearer token in the response body that looks like a very large string of random letters/numbers.
5. Finally navigate to the top of the page and click on the **Authorize** button, paste your Token string in there and select Authorize. 
6. Congrats! You now have the full functionality of the site.
<hr/>

## _Postman Instructions_
Postman is a resource for testing API calls, follow these steps to utilize this program:
1. Download [Postman](https://www.postman.com/downloads/). (Sign up is _not_ required).
2. Once the project API is live on _localhost:5000_, open Postman.
<div style="display: flex; justify-content: center"><img src="AnimalShelter\wwwroot\register.png"></div>

3. Make a **POST** to `localhost:5000/api/authenticate/register`.

<div style="display: flex; justify-content: center"><img src="AnimalShelter\wwwroot\login.png"></div>

4. Now just change the url to `/api/authenticate/register` , click send again. You will receive your token in the response body below.

<div style="display: flex; justify-content: center"><img src="AnimalShelter\wwwroot\token.png"></div>

5. Copy and paste the your token into the "Authorize" panel , after changing authorization type to bearer token. You're all Set! You can now search for the full list of animals or filter your search by name, species, breed, gender.
 _Example_
``localhost:5000/api/animals/?gender=female``

---
This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Cross-version performance is neither implied nor guaranteed, your actual mileage may vary.


## Technologies Used

* [C#](https://en.wikipedia.org/wiki/C_Sharp_(programming_language))
* [.NET](https://dotnet.microsoft.com/en-us/)
* [Entity Framework](https://docs.microsoft.com/en-us/ef/)
* [SQL Workbench](https://www.mysql.com/products/workbench/)
* [MVC](https://developer.mozilla.org/en-US/docs/Glossary/MVC)
* [Swagger](https://swagger.io/)
* [Postman](https://learning.postman.com/docs/getting-started/introduction/)


---

## _Specs_

|Behavior|Input|Output|
|-----|-----|-----|
|User can register an account in Swagger|"username": "test" , "password":  "test"|"api/Authenticate/register"|
|User can log in and generate bearer token on Swagger UI|Username and password from above|"/api/Authenticate/login"|
|User can post, edit, or delete entries once logged in|PUT, POST, or DELETE|"api/Destinations/{id}"|



---
## _Known Bugs_

* _Have not established roles in authorization to prevent users from deleting entries that are not theirs._

## _Legal_

_Copyright (c) Joseph Jack 2022_