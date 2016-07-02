function baseToDecimal(args) {
    var i,
        digit,
        numeralSystem = 2,
        inputNumber = args[0],
        decimalNumber = 0;

    for (i = 0, len = inputNumber.length; i < len; i += 1) {

        decimalNumber *= numeralSystem;

        switch (inputNumber[i]) {
            case 'A':
                digit = 10;
                break;
            case 'B':
                digit = 11;
                break;
            case 'C':
                digit = 12;
                break;
            case 'D':
                digit = 13;
                break;
            case 'E':
                digit = 14;
                break;
            case 'F':
                digit = 15;
                break;
            default:
                digit = +inputNumber[i];
        }

        decimalNumber += digit;

    }

    return decimalNumber;
}

console.log(hexToDecimal(['FE']));
console.log(hexToDecimal(['1AE3']));
console.log(hexToDecimal(['4ED528CBB4']));
