/* RUN: %llvmgcc %s -S -o - -O3 | grep {call.*memcpy}

 This should compile into a memcpy from a global, not 128 stores. */



void foo();

float bar() {
	float lookupTable[] = {-1,-1,-1,0, -1,-1,0,-1, -1,-1,0,1, -1,-1,1,0,
						   -1,0,-1,-1, -1,0,-1,1, -1,0,1,-1, -1,0,1,1,
						   -1,1,-1,0, -1,1,0,-1, -1,1,0,1, -1,1,1,0,
						   0,-1,-1,-1, 0,-1,-1,1, 0,-1,1,-1, 0,-1,1,1,
						   1,-1,-1,0, 1,-1,0,-1, 1,-1,0,1, 1,-1,1,0,
						   1,0,-1,-1, 1,0,-1,1, 1,0,1,-1, 1,0,1,1,
						   1,1,-1,0, 1,1,0,-1, 1,1,0,1, 1,1,1,0,
						   0,1,-1,-1, 0,1,-1,1, 0,1,1,-1, 0,1,1,1};
   foo(lookupTable);
}

