function mmsa(args) {
    var i,
        average,
        numbers = args.map(Number),
        len = numbers.length,
        min = numbers[0],
        max = numbers[0],
        sum = 0;

    for (i = 0; i < len; i += 1) {
        if (numbers[i] > max) {
            max = numbers[i];
        }
        if (numbers[i] < min) {
            min = numbers[i];
        }
        sum += numbers[i];
    }

    average = sum / len;

    return 'min=' + min.toFixed(2) + '\nmax=' + max.toFixed(2) + '\nsum=' + sum.toFixed(2) + '\navg=' + average.toFixed(2);
}

console.log(mmsa(['2', '5', '1']));
console.log('\n' + mmsa(['2', '-1', '4']));
