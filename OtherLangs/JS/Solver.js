const bdm = function(buffer, t) {
    let e = 0;

    for (const byte of buffer) {
        e = (e << 8) | byte;
        e %= t;
    }

    return e;
}

const computePoW = function(payload) {
    let { sec, timestamp, nonce, difficulty} = payload;
    const nVals = [];
    while (true) {
        const randomBytes = crypto.randomBytes(8).toString('hex');
        const n = `0.${randomBytes}`;
        const toHash = `${sec}${timestamp}${nonce}${difficulty}${n}`;
        const hash = crypto.createHash('sha256').update(toHash, 'ascii').digest();

        if (bdm(hash, difficulty) === 0) {
            difficulty++;
            nVals.push(n);
            if (nVals.length === 10) {
                break;
            }
            continue;
        }
    }
    return nVals;
}
