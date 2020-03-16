var CounterImages = 1;

function addImage() {
    var image = document.createElement (tagName: "img")
    var list = document.getElementByID (elementid: "imagesList")

    image.src = "https://placeimg.com/250/150/" + CounterImages;
    list.appendChild(image);

    var counter = document-getElementByID (elementid: "imageCounter");
    counter.innerText = counterImages.toString();

    counterImages++;
}