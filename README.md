# Toolapp
Tool App

Tool App est une desktop application créer en c# (windows form c#) formé de 6 outils.
Utiliser Soap service wsdl
<br/>
•	Calculatrice: 
URL wsdl: http://www.dneonline.com/calculator.asmx?wsdl
 
Utiliser Restful api

Méthode : Http client 
La classe HttpClient fournit une classe de base pour envoyer/recevoir les requêtes/réponses HTTP à partir d'une URL. Il est pris en charge par la fonctionnalité asynchrone (Toutes les méthodes avec HttpClient sont asynchrones.)

•	Myip :  permet d'identifier adresse ip de la machine sur le réseau
Endpoint : https://api.ipify.org?format=json
Methode: get
Response format: JSON

 




•	Myip :  permet de generate Radom joker or  Radom jokes selon une catégories .
Endpoint:
 https://api.chucknorris.io/jokes/random
https://api.chucknorris.io/jokes/random?category={categorie}
Methode: get
Response format: JSON

 


•	Géolocalisation IP : est le mappage d'une adresse IP à l'emplacement géographique d'Internet à partir de l'appareil connecté. En cartographiant géographiquement l'adresse IP, il vous fournit des informations de localisation telles que le pays, l'état, la ville, le code postal, la latitude/longitude, le FAI, l'indicatif régional et d'autres informations.

Endpoint: https://freegeoip.app/json
Methode: get
Response format: JSON
 


•	RestCountires :  permet de Recherche des information (nom, flag, la devise du pays, la capitale, l'indicatif d'appel, la région, la sous-région, la langue ISO 639-1, le nom ou l'indicatif du pays.) par nom de pays. 
 Endpoint : https://restcountries.com/v3.1/name={countryname}
Methode: get
Response format: JSON

 

•	Rando Pictures :  Cet outil d'images vous permet de retourner un animal au hasard. 
 Endpoint: https://random.dog/woof.json
Methode: get
Response format: JSON

 

•	Jokes :  l'outil vous permet également de jouer vous-même dans les jokes  en changeant le nom du personnage principal.
 Endpoint: http://api.icndb.com/jokes/random?firstName= {firstName} &lastName= {lastName}
Response format: JSON

 

•	Random  :  outil for interesting facts about numbers. Provides trivia, math, date, and year facts about numbers.
 Endpoint : 
http://numbersapi.com /random/trivia
http://numbersapi.com / random/year

http://numbersapi.com /random/math
http://numbersapi.com / random/date
Methode: get
Response format: JSON

 


