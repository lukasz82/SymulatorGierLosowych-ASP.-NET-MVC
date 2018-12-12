function GetNumberOfPlayslip(input, count, numbersDiv, resDiv, anyNumberClicked) {
    if (anyNumberClicked == false) {
        //debugger;
        if (input == "+") {
            count++;
            RenderCoupon(count, numbersDiv, resDiv);
            return;
        }
        if (input == "-") {
            count--;
            RenderCoupon(count, numbersDiv, resDiv);
            return;
        }

        if (input == "button") {
            count = $("#numbers").val();
            RenderCoupon(count, numbersDiv, resDiv);
            return;
        }
    }
    else if (anyNumberClicked == true) {
        $('#messages').html('Nie możesz dodać więcej losów po zaznaczeniu liczb, odśwież stronę.');
    }
}