$(document).ready(function() {
    loadData();
})
function loadData() {
    $.ajax({
        url: "https://localhost:44331/api/view?carid=1",
        method: "Get",
        //data: "",
        contentType: "application/json",
        dataType: "json"
    }).done(function (repponse) {
        var ihtml = $(`<h1><span class="value">` + repponse.carName + `</span></h1>
    <table border="1" style="width: 100%">
        <tbody>
            <tr>
                <td style="width:700px; height:400px;" rowspan="2"><img src="`+ repponse.image + `" style = "width:700px; height:400px; margin:0px;"/></td>
                <td><p class="attributeCar">Decription:</br><span class="value"> `+
                repponse.carDes + `</span></p> <p class="attributeCar">Color:<span class="value">` +
                repponse.carColor + `</span></p><p class="attributeCar">Price:<span class="value"> ` +
                repponse.price + `</span></p><p class="attributeCar">Quantity:<span class="value"> ` +
                repponse.carQuantity + `</span></p><p class="attributeCar">Category:<span class="value"> ` +
                repponse.carCategory + `</span></p></td>
            </tr>
            <tr>
                <td height="100px"><button style="margin-left:20px;background-color:#00adef;color:white;height:50px;width:360px;padding:0 10px">Add To Cart</button>
                    <button style="margin-left:30px;margin-top:10px;background-color:white;color:#00adef;height:50px;width:360px;padding:0 10px">Buy Now</button>
                </td>
            </tr>
        </tbody>
    </table>`);
            $('.detailpage').append(ihtml);
        
    }
    )
}

    

var data = [
    {
        carId: "2",
        name: "Audi R8",
        color: "Black",
        price: "150000",
        quantity: "1000",
        image: "https://images.honestjohn.co.uk/imagecache/file/crop/1200x800/media/14941146/Audi~R8~Performance~(01).jpg",
        decription: "asdasd",
        categoryID: "Audi",
        status: "1"
    }
]