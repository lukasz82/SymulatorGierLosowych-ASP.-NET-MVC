function ClickedCouponNumber(divIndex) {
    var string = divIndex;
    var returnString = '';
    for (var j = 0; j <= string.length; j++) {
        if (string[j] == '|') {
            //console.log('zwrocony string = ' + returnString);
            return returnString;
            
        }
        returnString += string[j];
    }
}