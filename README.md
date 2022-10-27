# castanedaPGreaterThanOrLessThanEnpoint

Created a controller that has an enpoint which calls a function to run some comparison operations between two numbers given by the user.

Peer Review by: Freddy Aguilar - The program converts mini challenge 4 into API format. It takes two numbers from the user and outputs onto Postman whether the first number is greater than, less than or equal to the second number. Everything works as intended.

To run this program you must open Postman app. Then from IDE you use to open code file run the Debug. Once you run it get the localhost server information and copy and paste it the the url box in Postman. Add the name of the Controller minus the "Controller" portion of the file name. Then add the route name. Use this format (localhost/7126/controllernamehere/routenamehere). You will need to write a JSON format code in Postman under body/raw/JSON once in the JSON file input the JSON format code like this {"variablename" : "your input here"}. The "variablename" can be found under Models folder in IDE. After you finish inputing the JSON code click "send" next to the url box in Postman. You will then see the result in the Postman console.

If api does not have models follow this format in the URL (localhost/7126/controllername/routename/{num1}/{num2} <-- input(s) here at the end of url
