// Initialization of 2D array
 #include<stdio.h>
 void main()
 {
 	int row, col, arr[2][2]={{1,2},{3,4}};
 	for(row=0;row<2;row++)
 	{
 		for(col=0;col<2;col++)
		{
		 	printf("arr[%d][%d] = %d\n",row,col,arr[row][col]);
		}	
	}
 }
 
// Algorithum
// 1) start
// 2) declare variable row,col,arr[2][2]= value initialisation
// 3) if row=0;row<2;row++;
// 4) for col=0;col<2;col++ then 
// 5) print row column
// 6) stop
// 
