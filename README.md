# unlockmind-greyscale-reader
Converts an image into a 2D array containing the percentage of blackness for-each pixel

Converting a image into a 2D grayscale array
```c#
var array2D = new Greyscale2DArray(@"C:\Users\enisn\Desktop\NN\2.png");
```


Percentual 2D Array Visualization
```c#
new ConsleDisplayScaleArray(array2D.Value, array2D.Height, array2D.Width);
```

Examples

![alt text](https://i.ibb.co/1LJfnsc/0rb.png)

![alt text](https://i.ibb.co/xDwrq9R/2bn.png)

![alt text](https://i.ibb.co/GR9mHD0/rbface.png)


