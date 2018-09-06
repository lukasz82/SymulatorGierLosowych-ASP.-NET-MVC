function RenderCoupon(quantity, numbersDiv, resDiv) {
    count = quantity;
    if (count < 100 & count >= 0) {
        var res = "";
        var n = "";
        n += '<div style="float:left;">';
        for (var j = 1; j <= count; j++) {
            var counter = 2;
            n += '<div id= ' + j + ' style="float:left;"> <div style="background-color: #f0f0f5; width: 92%;"> Los nr. ' + j + '</div><br >';
            for (var i = 1; i <= 49; i++) {
                if (counter != 11) {
                    n += '<div class="number" type="button" id="' + j + "|" + i + '" style="float:left; width:30px; text-align:right; cursor: pointer;" >' + i + '</div>';
                }

                if (counter == 11) {
                    n += '<div class="number" type="button" id="' + j + "|" + i + '" style="float:left; width:30px; text-align:right; cursor: pointer;">' + i + '</div>';
                    n += '<div style="float:left; width:30px;"></div>';
                    n += '<br />';
                    counter = 1;
                }
                counter++;
            }
            n += '<br /><br />';
            n += '</div>';
        }
        res = res + n;

    }
    n += '</div>';
    numbersDiv.val(count);
    resDiv.html(res);
}