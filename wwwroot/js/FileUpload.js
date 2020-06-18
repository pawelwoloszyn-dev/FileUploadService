
async function uploadFiles(inputId) {
    var input = document.getElementById(inputId);
    var files = input.files;
    var key = "11ebbf07-76de-4b5c-b107-53441c964b8b";
    var url = "https://localhost:44314/uploader/"+key+"/upload"
  
    for (var i = 0; i != files.length; i++) {
        var file = files[i];
        var reader = new FileReader();
        reader.readAsDataURL(file);
        await reader.addEventListener("load",
            async function(){
                let data={
                    fileName: document.getElementById(inputId).value,
                    fileContentBase64JS: this.result
                };    
                let params={
                    headers:{
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    },
                    body:JSON.stringify(data),
                    method:"POST"
                };
                fetch(url, params)
                    .then(response => console.log(response.json()))
        });
    }
}
