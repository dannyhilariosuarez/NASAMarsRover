# NASAMarsRover

Your app will use NASA’s Mars Rover Photos API to download photos from a given day. You can find details of the API here: https://api.nasa.gov/



NASAMarsRover accept a REST request that contains a date. It will then use NASA’s API to look for photos on that date. If that date contains any images download all the images at the location returned and save them to a directory the date that they came from. The response to the REST request should return whether the API call to NASA was successful and how many images were downloaded and saved.
</br>
</br>
</br>
<h3> NASA's Mars Rover Photos API response looks like</h3> 
</br>

![dotCMS logo](https://user-images.githubusercontent.com/21280365/156388842-2b386386-869e-45de-9e4e-b65b1be92896.png)
 
</br>
</br>
</br>

<h3> NASAMarsRover API Rest out looks like</h3> 
</br>
![dotCMS logo](https://user-images.githubusercontent.com/21280365/156389182-fd96e00d-2678-4be5-a215-ed8b501028f6.png)
 
</br>
</br>
</br>

<h2>Initialize MASAMarsRover project with Visual Studio Code:</h2>



When the project folder is first opened in VS Code:
 
A "Required assets to build and debug are missing. Add them?" notification appears at the bottom right of the window.
Select Yes. (Probably you will need to install Install NewtonSoft.Json)
</br>

Open a new Terminal.
</br>

Enter the following command in the command shell:</br>
<code>cd NASAMarsRover</code>
</br>
  
Run the app by entering the following command in the command shell: </br>
<code>dotnet run</code>
</br>
</br>

In the command shell copy the url on "Now listening on: https://localhost:..." and opened in the browser.
</br>
</br>

At the end of the url paste "/swagger/index.html":</br>
https://localhost:7234/swagger/index.html
</br>
</br>

Select "GET /NASAMarsRoverPhotos" to make a call to the api.
</br>
</br>

Click on Try it out.
</br>

Enter an earth_date (the day you want) with the following format:</br>
yyyy-mm-dd (2015-6-3)
</br>
</br>

To run the request click on Execute button 
<br />
<br />
<br />
<h2>Run MASAMarsRoverTEST project:</h2>
<br />
<br />
Enter the following command in the command shell:</br>
<code>cd NASAMarsRoverTest</code>
</br>
<br/>
Run the app by entering the following command in the command shell:</br>
<code>dotnet test</code>
</br>
</br>
</br>

