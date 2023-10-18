// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const getDataButton = document.getElementById("getDataButton");

getDataButton.addEventListener("click", () => {
    
    fetch('https://weed-strain1.p.rapidapi.com/')
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json(); 
        })
        .then(data => {
            
            console.log(data);
            
        })
        .catch(error => {
            console.error('There was a problem with the network request:', error);
        });
})