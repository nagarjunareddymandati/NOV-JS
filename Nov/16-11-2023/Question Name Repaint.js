function repaint(c, n) {
    let ans = 0;
    let found = false;
    for (let i = 0; i < n / 2; i++) {

        if (c[i] === c[n - i - 1]) {
            found = true;
            break;
        }
        ans += 2;
    }
    if (found) ans += 1;
    return ans;
}
var n = readline();
var temp = readline().trim();
var s = temp.split(" ");
for (i = 0; i < n; i++) {
    s[i] = Number(s[i]);
}
var num = repaint(s, n);
print(num);