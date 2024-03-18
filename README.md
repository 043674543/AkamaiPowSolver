# Akamai Anti-Bot Proof of Work Solver

This C# project contains a proof of work solver for the Akamai Anti-Bot system. It computes the required proof of work (PoW) values based on the given parameters.

## Usage

To use the solver, create an instance of the `Solver` class with the following parameters:

- `sec`: The security code string.
- `timestamp`: The timestamp value.
- `nonce`: The nonce string.
- `difficulty`: The initial difficulty level.

Then, call the `ComputePoW()` method to generate a list of 10 valid proof of work values.

