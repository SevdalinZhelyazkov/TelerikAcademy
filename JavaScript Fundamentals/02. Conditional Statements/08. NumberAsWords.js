function numberAsWords(args) {
    var number = +args[0],
        hundreds = (number / 100) | 0,
        tens = (number % 100 / 10) | 0,
        ones = number % 100 % 10,
        result = '';

    if (number > 999 || number < 0) {
        return 'Invalid number!';
    }

    if (number === 0) {
        return 'Zero';
    }

    if (hundreds > 0) {
        switch (hundreds) {
            case 1:
                result += 'One hundred ';
                break;
            case 2:
                result += 'Two hundred ';
                break;
            case 3:
                result += 'Three hundred ';
                break;
            case 4:
                result += 'Four hundred ';
                break;
            case 5:
                result += 'Five hundred ';
                break;
            case 6:
                result += 'Six hundred ';
                break;
            case 7:
                result += 'Seven hundred ';
                break;
            case 8:
                result += 'Eight hundred ';
                break;
            case 9:
                result += 'Nine hundred ';
                break;
        }

        if ((tens !== 0) || ones !== 0) {
            result += 'and ';
        }
    }

    if (tens > 1) {
        switch (tens) {
            case 2:
                result += 'twenty ';
                break;
            case 3:
                result += 'thirty ';
                break;
            case 4:
                result += 'fourty ';
                break;
            case 5:
                result += 'fifty ';
                break;
            case 6:
                result += 'sixty ';
                break;
            case 7:
                result += 'seventy ';
                break;
            case 8:
                result += 'eighty ';
                break;
            case 9:
                result += 'ninety ';
                break;
        }
    } else if (tens == 1) {
        switch (ones) {
            case 0:
                result += 'ten';
                break;
            case 1:
                result += 'eleven ';
                break;
            case 2:
                result += 'twelve ';
                break;
            case 3:
                result += 'thirteen ';
                break;
            case 4:
                result += 'fourteen ';
                break;
            case 5:
                result += 'fifteen ';
                break;
            case 6:
                result += 'sixteen ';
                break;
            case 7:
                result += 'seventeen ';
                break;
            case 8:
                result += 'eighteen ';
                break;
            case 9:
                result += 'nineteen ';
                break;
        }
    }

    if (tens != 1) {
        switch (ones) {
            case 1:
                result += 'one';
                break;
            case 2:
                result += 'two';
                break;
            case 3:
                result += 'three';
                break;
            case 4:
                result += 'four';
                break;
            case 5:
                result += 'five';
                break;
            case 6:
                result += 'six';
                break;
            case 7:
                result += 'seven';
                break;
            case 8:
                result += 'eight';
                break;
            case 9:
                result += 'nine';
                break;
        }
    }

    result = result.trim();
    return result.charAt(0).toUpperCase() + result.slice(1);
}

console.log(numberAsWords(['-1']));
console.log(numberAsWords(['0']));
console.log(numberAsWords(['10']));
console.log(numberAsWords(['310']));
console.log(numberAsWords(['999']));
console.log(numberAsWords(['1000']));