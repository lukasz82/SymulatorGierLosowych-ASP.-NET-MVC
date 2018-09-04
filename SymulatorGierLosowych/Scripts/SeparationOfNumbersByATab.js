function SeparationOfNumbersByATab(table, whichTableToReturn) {
    var numbersTab = [];
    var couponsTab = [];
    for (var i = 0; i < table.length; i++) {
        var string = table[i];
        var isTab = false;
        var couponNumber = '';
        var number = '';
        for (var j = 0; j <= string.length; j++) {
            if (string[j] == '|') {
                couponsTab.push(couponNumber);
                couponNumber = '';
                isTab = true;
                continue;
            }

            if (j == string.length) {
                numbersTab.push(number);
                number = '';
                isTab = false;
            }

            if (isTab == false) couponNumber += string[j];
            if (isTab == true) number += string[j];

            //console.log('string' + string[j]);
        }

    }
    if (whichTableToReturn == 2) return couponsTab;
    if (whichTableToReturn == 1) return numbersTab;

}