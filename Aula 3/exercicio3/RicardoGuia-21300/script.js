function getLinkAtributes() {
    var link = document.getElementById("link");
    var list = document.getElementById("infoLink");
    list.innerHTML = "";
    list.appendChild(this.createNode("ID", link.id));
    list.appendChild(this.createNode("HREF",link.href));
    list.appendChild(this.createNode("TARGET",link.target));
    list.appendChild(this.createNode("TYPE",link.type));

}

function createNode(title, value) {
    var li = document.createElement("li");
    li.innerHTML = title + ":" + value;
    return li;
}

function setTitlesRed() {
    for (let elem of document.getElementsByClassName("titles")) {
        elem.style.color = "red";
    }
}
