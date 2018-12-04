function RenderCoupon(quantity, numbersDiv, resDiv) {
    count = quantity;
    if (count < 100 & count >= 0) {
        var res = "";
        var n = "";
        n += '<div class="row">';
        for (var j = 1; j <= count; j++) {
            var counter = 2;
            n += '<div class="coupon" style="float:left; width:350px; padding:5px;">';
            n += '<div id=' + j + ' style="background-color: #f0f0f5;"> Los nr. ' + j + '</div>';
            for (var i = 1; i <= 49; i++) {
                if (counter != 11) {
                    n += '<div class="number" type="button" id="' + j + "|" + i + '" style="float:left; width:30px; text-align:right; cursor: pointer; border: 1px solid #FFFFFF" >' + i + '</div>';
                }

                if (counter == 11) {
                    n += '<div class="number" type="button" id="' + j + "|" + i + '" style="float:left; width:30px; text-align:right; cursor: pointer; border: 1px solid #FFFFFF">' + i + '</div>';
                    n += '<br />';
                    counter = 1;
                }
                counter++;
            
            }
            n += '</div>';
        }
        n += '<br />';
        n += '</div>';
    }
   
    res = res + n;
    numbersDiv.val(count);
    resDiv.html(res);
}