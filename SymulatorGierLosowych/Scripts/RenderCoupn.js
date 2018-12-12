function RenderCoupon(quantity, numbersDiv, resDiv) {
    count = quantity;
    if (count < 100 & count >= 0) {
        var res = "";
        var n = "";

        n += '<div class="container" style="background-color: #ffffff;">'; // 0
        n += '<div class="row" style="background-color: #ffffff;">'; // 1
        for (var j = 1; j <= count; j++) {
            var counter = 0;
            n += '<div class="coupon" style="float:left; width:350px; padding:5px;">'; // 2
            n += '<div id=' + j + ' style="background-color: #f0f0f5;"> Los nr. ' + j + '</div>'; // 2
            for (var i = 1; i <= 49; i++) {
                n += '<div class="number" type="button" id="' + j + "|" + i + '" style="background-color: #ffffff; float:left; width:30px; cursor: pointer; border: 1px solid #FFFFFF;">' + i + ' </div>'; // 3
                if (counter == 10) {
                    n += '<div style="background-color: #ffffff; float:left; width:350px; height:2px;"></div>'; // 3
                }
                // TODO nie podoba mnie się ten counter, za bardzo namięszałem, zrobić prościej
                counter++;
                if (counter >= 10) {
                    counter = 0;
                }
            }
            n += '</div>'; // 2
        }

        n += '</div>'; // 1
        n += '</div>'; // 0

        n += '<div class="container" style="background-color: #aaaaaa;">'; // 0
        n += '<div class="row" style="background-color: #cccccc;">'; // 1
        n += '<dic class="innedane">Jakieś inne dane tutaj będą</div>';
        n += '</div>'; // 1
        n += '</div>'; // 0
    }
   
    res = res + n;
    numbersDiv.val(count);
    resDiv.html(res);
}