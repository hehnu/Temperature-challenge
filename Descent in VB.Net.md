{\rtf1\ansi\ansicpg1252\cocoartf2580
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fnil\fcharset0 Menlo-Regular;}
{\colortbl;\red255\green255\blue255;\red0\green0\blue0;\red255\green255\blue255;\red15\green112\blue1;
\red0\green0\blue255;\red0\green0\blue109;\red157\green0\blue210;\red32\green108\blue135;\red19\green118\blue70;
\red101\green76\blue29;}
{\*\expandedcolortbl;;\cssrgb\c0\c0\c0;\cssrgb\c100000\c100000\c100000;\cssrgb\c0\c50196\c0;
\cssrgb\c0\c0\c100000;\cssrgb\c0\c6275\c50196;\cssrgb\c68627\c0\c85882;\cssrgb\c14902\c49804\c60000;\cssrgb\c3529\c52549\c34510;
\cssrgb\c47451\c36863\c14902;}
\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\deftab720
\pard\pardeftab720\sl360\partightenfactor0

\f0\fs24 \cf2 \cb3 \expnd0\expndtw0\kerning0
\outl0\strokewidth0 \strokec2 Module Player\cb1 \
\pard\pardeftab720\sl360\partightenfactor0
\cf4 \cb3 \strokec4 ' The while loop represents the game.\cf2 \cb1 \strokec2 \
\cf4 \cb3 \strokec4 ' Each iteration represents a turn of the game\cf2 \cb1 \strokec2 \
\cf4 \cb3 \strokec4 ' where you are given inputs (the heights of the mountains)\cf2 \cb1 \strokec2 \
\cf4 \cb3 \strokec4 ' and where you have to print an output (the index of the mountain to fire on)\cf2 \cb1 \strokec2 \
\cf4 \cb3 \strokec4 ' The inputs you are given are automatically updated according to your last actions.\cf2 \cb1 \strokec2 \
\
\pard\pardeftab720\sl360\partightenfactor0
\cf2 \cb3     \cf5 \strokec5 Sub \cf6 \strokec6 Main\cf2 \strokec2  ()\cb1 \
\cb3         \cb1 \
\cb3         \cf4 \strokec4 ' game loop\cf2 \cb1 \strokec2 \
\cb3         \cf7 \strokec7 While\cf5 \strokec5  True\cf2 \cb1 \strokec2 \
\cb3            \cf5 \strokec5 Dim\cf6 \strokec6  highestMountain \cf2 \strokec2 As \cf8 \strokec8 Integer\cf2 \cb1 \strokec2 \
\cb3            \cf6 \strokec6 highestMountain\cf2 \strokec2  = \cf9 \strokec9 0\cf2 \cb1 \strokec2 \
\cb3            \cf5 \strokec5 Dim\cf6 \strokec6  highestMountainIndex \cf2 \strokec2 As \cf8 \strokec8 Integer\cf2 \cb1 \strokec2 \
\cb3            \cf6 \strokec6 highestMountainIndex\cf2 \strokec2  = \cf9 \strokec9 0\cf2 \cb1 \strokec2 \
\cb3            \cb1 \
\cb3            \cb1 \
\cb3             \cf7 \strokec7 For\cf2 \strokec2  i as \cf8 \strokec8 Integer\cf2 \strokec2  = \cf9 \strokec9 0\cf2 \strokec2  \cf7 \strokec7 To\cf2 \strokec2  \cf9 \strokec9 7\cf2 \cb1 \strokec2 \
\cb3                 \cf5 \strokec5 Dim\cf6 \strokec6  mountainH \cf2 \strokec2 as \cf8 \strokec8 Integer\cf2 \cb1 \strokec2 \
\cb3                 \cf6 \strokec6 mountainH\cf2 \strokec2  = Console.\cf10 \strokec10 ReadLine\cf2 \strokec2 () \cf4 \strokec4 ' represents the height of one mountain.\cf2 \cb1 \strokec2 \
\
\pard\pardeftab720\sl360\partightenfactor0
\cf7 \cb3 \strokec7 if\cf2 \strokec2  \cf6 \strokec6 mountainH\cf2 \strokec2  >\cf6 \strokec6  highestMountain\cf2 \strokec2  \cf7 \strokec7 Then\cf2 \cb1 \strokec2 \
\pard\pardeftab720\sl360\partightenfactor0
\cf2 \cb3             \cf6 \strokec6 highestMountainIndex\cf2 \strokec2  =\cf6 \strokec6  i\cf2 \cb1 \strokec2 \
\cb3             \cf6 \strokec6 highestMountain\cf2 \strokec2  =\cf6 \strokec6  mountainH\cf2 \cb1 \strokec2 \
\cb3             \cf7 \strokec7 End If\cf2 \cb1 \strokec2 \
\cb3         \cf7 \strokec7 Next\cf2 \cb1 \strokec2 \
\
\
\
\cb3             \cf4 \strokec4 ' Write an action using Console.WriteLine()\cf2 \cb1 \strokec2 \
\cb3             \cf4 \strokec4 ' To debug: Console.Error.WriteLine("Debug messages...")\cf2 \cb1 \strokec2 \
\
\cb3             Console.\cf10 \strokec10 WriteLine\cf2 \strokec2 (\cf6 \strokec6 highestMountainIndex\cf2 \strokec2 ) \cf4 \strokec4 ' The index of the mountain to fire on.\cf2 \cb1 \strokec2 \
\cb3         \cf10 \strokec10 End\cf2 \strokec2  \cf7 \strokec7 While\cf2 \cb1 \strokec2 \
\cb3     \cf5 \strokec5 End Sub\cf2 \cb1 \strokec2 \
\pard\pardeftab720\sl360\partightenfactor0
\cf10 \cb3 \strokec10 End\cf2 \strokec2  Module\cb1 \
}