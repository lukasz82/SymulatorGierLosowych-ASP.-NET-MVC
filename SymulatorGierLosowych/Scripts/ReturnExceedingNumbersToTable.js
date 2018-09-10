function ReturnExceedingNumbersToTable(table)
{
    //console.log('tablica przekazana z funkcji' + table);
    var max = table.length;
    var coupon_count = 0;
    //console.log('res: ' + table);
    //console.log('max: ' + max);
    let couponsQuantity = [];

    // Zerowanie tablicy couponsQuantity
    for (var j = 0; j <= max; j++)
    {
        couponsQuantity[j] = 0;
    }

    //console.log('zerowanie' + couponsQuantity);

    // Analizowanie tablicy w celu wyłapania ilości klikniętych 
    for (var i = 1; i <= max; i++)
    {
        for (var j = 0; j < max; j++)
        {
            if (i == table[j])
            {
                //console.log('i jest rownowazne table[j] : i = ' + i + 'table[j] = ' + table[j]);
                coupon_count++;
            }
        }

        if (coupon_count > 0)
        {
            couponsQuantity[i] = coupon_count;
        }
        coupon_count = 0;
    }
    //console.log('coupon count !!! : ' + couponsQuantity);
    return couponsQuantity;
}