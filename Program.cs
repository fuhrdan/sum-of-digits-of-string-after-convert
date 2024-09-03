//*****************************************************************************
//** 1945 Sum of Digits of String After Convert  leetcode                    **
//*****************************************************************************


int getLucky(char* s, int k) {
    int len = strlen(s);
    int* convert = (int*)malloc(len * sizeof(int));
    int totesMyGoats = 0;
    // Convert each character to a number and then sum their digits
    for (int i = 0; i < len; i++) {
        int num = s[i] - 'a' + 1; // Convert character to number ('a' -> 1, 'b' -> 2, etc.)
        // Sum digits of the number (e.g., 'j' -> 10 -> 1 + 0 = 1)
        while (num > 0) {
            totesMyGoats += num % 10;
            num /= 10;
        }
    }

    // Repeat the summing process k-1 more times
    for (int j = 1; j < k; j++) {
        int newSum = 0;
        while (totesMyGoats > 0) {
            newSum += totesMyGoats % 10;
            totesMyGoats /= 10;
        }
        totesMyGoats = newSum;
    }
    free(convert);
    return totesMyGoats;
}