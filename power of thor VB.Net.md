{\rtf1\ansi\ansicpg1252\cocoartf2580
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fnil\fcharset0 Menlo-Regular;}
{\colortbl;\red255\green255\blue255;\red0\green0\blue0;\red255\green255\blue255;\red15\green112\blue1;
\red0\green0\blue255;\red0\green0\blue109;\red32\green108\blue135;\red101\green76\blue29;\red144\green1\blue18;
\red19\green118\blue70;\red157\green0\blue210;}
{\*\expandedcolortbl;;\cssrgb\c0\c0\c0;\cssrgb\c100000\c100000\c100000;\cssrgb\c0\c50196\c0;
\cssrgb\c0\c0\c100000;\cssrgb\c0\c6275\c50196;\cssrgb\c14902\c49804\c60000;\cssrgb\c47451\c36863\c14902;\cssrgb\c63922\c8235\c8235;
\cssrgb\c3529\c52549\c34510;\cssrgb\c68627\c0\c85882;}
\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\deftab720
\pard\pardeftab720\sl380\partightenfactor0

\f0\fs26\fsmilli13200 \cf2 \cb3 \expnd0\expndtw0\kerning0
\outl0\strokewidth0 \strokec2 Module Player\cb1 \
\pard\pardeftab720\sl380\partightenfactor0
\cf4 \cb3 \strokec4 ' Auto-generated code below aims at helping you parse\cf2 \cb1 \strokec2 \
\cf4 \cb3 \strokec4 ' the standard input according to the problem statement.\cf2 \cb1 \strokec2 \
\cf4 \cb3 \strokec4 ' ---\cf2 \cb1 \strokec2 \
\cf4 \cb3 \strokec4 ' Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.\cf2 \cb1 \strokec2 \
\
\pard\pardeftab720\sl380\partightenfactor0
\cf2 \cb3     \cf5 \strokec5 Sub \cf6 \strokec6 Main\cf2 \strokec2  ()\cb1 \
\cb3         \cb1 \
\cb3         \cf5 \strokec5 Dim\cf6 \strokec6  inputs \cf2 \strokec2 as \cf7 \strokec7 String\cf2 \strokec2 ()\cb1 \
\cb3         \cf5 \strokec5 Dim\cf6 \strokec6  lightX \cf2 \strokec2 as \cf7 \strokec7 Integer\cf2 \strokec2  \cf4 \strokec4 ' the X position of the light of power\cf2 \cb1 \strokec2 \
\cb3         \cf5 \strokec5 Dim\cf6 \strokec6  lightY \cf2 \strokec2 as \cf7 \strokec7 Integer\cf2 \strokec2  \cf4 \strokec4 ' the Y position of the light of power\cf2 \cb1 \strokec2 \
\cb3         \cf5 \strokec5 Dim\cf6 \strokec6  initialTX \cf2 \strokec2 as \cf7 \strokec7 Integer\cf2 \strokec2  \cf4 \strokec4 ' Thor's starting X position\cf2 \cb1 \strokec2 \
\cb3         \cf5 \strokec5 Dim\cf6 \strokec6  initialTY \cf2 \strokec2 as \cf7 \strokec7 Integer\cf2 \strokec2  \cf4 \strokec4 ' Thor's starting Y position\cf2 \cb1 \strokec2 \
\cb3         \cf5 \strokec5 Dim\cf6 \strokec6  direction \cf2 \strokec2 as \cf7 \strokec7 String\cf2 \cb1 \strokec2 \
\cb3         \cf6 \strokec6 inputs\cf2 \strokec2  = Console.\cf8 \strokec8 ReadLine\cf2 \strokec2 ().\cf8 \strokec8 Split\cf2 \strokec2 (\cf9 \strokec9 " "\cf2 \strokec2 )\cb1 \
\cb3         \cf6 \strokec6 lightX\cf2 \strokec2  = \cf8 \strokec8 inputs\cf2 \strokec2 (\cf10 \strokec10 0\cf2 \strokec2 )\cb1 \
\cb3         \cf6 \strokec6 lightY\cf2 \strokec2  = \cf8 \strokec8 inputs\cf2 \strokec2 (\cf10 \strokec10 1\cf2 \strokec2 )\cb1 \
\cb3         \cf6 \strokec6 initialTX\cf2 \strokec2  = \cf8 \strokec8 inputs\cf2 \strokec2 (\cf10 \strokec10 2\cf2 \strokec2 )\cb1 \
\cb3         \cf6 \strokec6 initialTY\cf2 \strokec2  = \cf8 \strokec8 inputs\cf2 \strokec2 (\cf10 \strokec10 3\cf2 \strokec2 )\cb1 \
\
\cb3         \cf4 \strokec4 ' game loop\cf2 \cb1 \strokec2 \
\cb3         \cf11 \strokec11 While\cf5 \strokec5  True\cf2 \cb1 \strokec2 \
\cb3             \cf5 \strokec5 Dim\cf6 \strokec6  remainingTurns \cf2 \strokec2 as \cf7 \strokec7 Integer\cf2 \cb1 \strokec2 \
\cb3             \cf6 \strokec6 remainingTurns\cf2 \strokec2  = Console.\cf8 \strokec8 ReadLine\cf2 \strokec2 () \cf4 \strokec4 ' The remaining amount of turns Thor can move. Do not remove this line.\cf2 \cb1 \strokec2 \
\
\cb3             \cf4 \strokec4 ' Write an action using Console.WriteLine()\cf2 \cb1 \strokec2 \
\cb3             \cf4 \strokec4 ' To debug: Console.Error.WriteLine("Debug messages...")\cf2 \cb1 \strokec2 \
\cb3          \cf11 \strokec11 If\cf2 \strokec2  \cf6 \strokec6 lightX\cf2 \strokec2  <>\cf6 \strokec6 initialTX\cf2 \strokec2  \cf11 \strokec11 Then\cf2 \cb1 \strokec2 \
\cb3            \cf11 \strokec11 If\cf2 \strokec2  \cf6 \strokec6 lightX\cf2 \strokec2  >\cf6 \strokec6  initialTX\cf2 \strokec2  \cb1 \
\cb3             \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "E"\cf2 \cb1 \strokec2 \
\cb3             \cf11 \strokec11 Else\cf2 \cb1 \strokec2 \
\cb3             \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "W"\cf2 \cb1 \strokec2 \
\cb3             \cf11 \strokec11 End If\cf2 \cb1 \strokec2 \
\cb3         \cf11 \strokec11 End If\cf2 \cb1 \strokec2 \
\cb3         \cf11 \strokec11 If\cf2 \strokec2  \cf6 \strokec6 lightY\cf2 \strokec2  <>\cf6 \strokec6 initialTX\cf2 \strokec2  \cf11 \strokec11 Then\cf2 \cb1 \strokec2 \
\cb3            \cf11 \strokec11 If\cf2 \strokec2  \cf6 \strokec6 lightY\cf2 \strokec2  >\cf6 \strokec6  initialTY\cf2 \cb1 \strokec2 \
\cb3             \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "S"\cf2 \cb1 \strokec2 \
\cb3             \cf11 \strokec11 Else\cf2 \cb1 \strokec2 \
\cb3             \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "N"\cf2 \cb1 \strokec2 \
\cb3             \cf11 \strokec11 End If\cf2 \cb1 \strokec2 \
\cb3         \cf11 \strokec11 End If\cf2 \cb1 \strokec2 \
\
\cb3         \cf11 \strokec11 If\cf2 \strokec2  (\cf6 \strokec6 lightX\cf2 \strokec2  -\cf6 \strokec6  initialTX\cf2 \strokec2 ) = (\cf6 \strokec6 lightY\cf2 \strokec2 -\cf6 \strokec6 initialTY\cf2 \strokec2 )\cb1 \
\cb3         \cf11 \strokec11 If\cf2 \strokec2  \cf6 \strokec6 lightX\cf2 \strokec2  >\cf6 \strokec6  initialTX\cf2 \strokec2  AND \cf6 \strokec6 lightY\cf2 \strokec2  >\cf6 \strokec6  initialTY\cf2 \cb1 \strokec2 \
\cb3         \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "SE"\cf2 \cb1 \strokec2 \
\cb3         \cf11 \strokec11 End If\cf2 \cb1 \strokec2 \
\cb3          \cf11 \strokec11 If\cf2 \strokec2  \cf6 \strokec6 lightX\cf2 \strokec2  >\cf6 \strokec6  initialTX\cf2 \strokec2  AND \cf6 \strokec6 lightY\cf2 \strokec2  <\cf6 \strokec6  initialTY\cf2 \strokec2  \cb1 \
\cb3         \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "NE"\cf2 \cb1 \strokec2 \
\cb3           \cf11 \strokec11 End If\cf2 \cb1 \strokec2 \
\cb3          \cf11 \strokec11 If\cf2 \strokec2  \cf6 \strokec6 lightX\cf2 \strokec2  <\cf6 \strokec6  initialTX\cf2 \strokec2  AND \cf6 \strokec6 lightY\cf2 \strokec2  >\cf6 \strokec6  initialTY\cf2 \strokec2  \cb1 \
\cb3         \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "NW"\cf2 \cb1 \strokec2 \
\cb3           \cf11 \strokec11 End If\cf2 \cb1 \strokec2 \
\cb3          \cf11 \strokec11 If\cf2 \strokec2  \cf6 \strokec6 lightX\cf2 \strokec2  <\cf6 \strokec6  initialTX\cf2 \strokec2  AND \cf6 \strokec6 lightY\cf2 \strokec2  <\cf6 \strokec6  initialTY\cf2 \strokec2  \cb1 \
\cb3         \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "SW"\cf2 \cb1 \strokec2 \
\cb3         \cf11 \strokec11 End If\cf2 \cb1 \strokec2 \
\
\cb3     \cf11 \strokec11 End If\cf2 \cb1 \strokec2 \
\
\cb3     \cf5 \strokec5 Dim\cf6 \strokec6  SlopeX\cf2 \cb1 \strokec2 \
\cb3      \cf5 \strokec5 Dim\cf6 \strokec6  SlopeY\cf2 \cb1 \strokec2 \
\
\cb3     \cf6 \strokec6 SlopeX\cf2 \strokec2  =\cf6 \strokec6  lightX\cf2 \strokec2  -\cf6 \strokec6  initialTX\cf2 \cb1 \strokec2 \
\cb3     \cf6 \strokec6 SlopeY\cf2 \strokec2  =\cf6 \strokec6  lightY\cf2 \strokec2  -\cf6 \strokec6  initialTY\cf2 \cb1 \strokec2 \
\
\cb3     \cf11 \strokec11 If\cf2 \strokec2  \cf6 \strokec6 SlopeX\cf2 \strokec2  = \cf10 \strokec10 0\cf2 \strokec2  \cf11 \strokec11 Then\cf2 \cb1 \strokec2 \
\cb3         \cf11 \strokec11 if\cf2 \strokec2  \cf6 \strokec6 lightY\cf2 \strokec2  >\cf6 \strokec6  initialTY\cf2 \strokec2  \cf11 \strokec11 Then\cf2 \cb1 \strokec2 \
\cb3         \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "S"\cf2 \cb1 \strokec2 \
\cb3         \cf6 \strokec6 initialTY\cf2 \strokec2  =\cf6 \strokec6  initialTY\cf2 \strokec2  + \cf10 \strokec10 1\cf2 \cb1 \strokec2 \
\cb3     \cf11 \strokec11 Else\cf2 \cb1 \strokec2 \
\cb3         \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "N"\cf2 \cb1 \strokec2 \
\cb3         \cf6 \strokec6 initialTY\cf2 \strokec2  =\cf6 \strokec6  initialTY\cf2 \strokec2  - \cf10 \strokec10 1\cf2 \cb1 \strokec2 \
\cb3     \cf11 \strokec11 End if\cf2 \cb1 \strokec2 \
\pard\pardeftab720\sl380\partightenfactor0
\cf11 \cb3 \strokec11 Else\cf2 \cb1 \strokec2 \
\pard\pardeftab720\sl380\partightenfactor0
\cf2 \cb3     \cf11 \strokec11 If\cf2 \strokec2  \cf6 \strokec6 SlopeY\cf2 \strokec2  = \cf10 \strokec10 0\cf2 \strokec2  \cf11 \strokec11 Then\cf2 \cb1 \strokec2 \
\cb3         \cf11 \strokec11 If\cf2 \strokec2  \cf6 \strokec6 lightX\cf2 \strokec2  >\cf6 \strokec6  initialTX\cf2 \strokec2  \cf11 \strokec11 Then\cf2 \cb1 \strokec2 \
\cb3             \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "E"\cf2 \cb1 \strokec2 \
\cb3             \cf6 \strokec6 initialTX\cf2 \strokec2  =\cf6 \strokec6  initialTX\cf2 \strokec2  + \cf10 \strokec10 1\cf2 \cb1 \strokec2 \
\pard\pardeftab720\sl380\partightenfactor0
\cf11 \cb3 \strokec11 Else\cf2 \cb1 \strokec2 \
\pard\pardeftab720\sl380\partightenfactor0
\cf2 \cb3     \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "W"\cf2 \cb1 \strokec2 \
\cb3     \cf6 \strokec6 initialTX\cf2 \strokec2  =\cf6 \strokec6  initialTX\cf2 \strokec2  - \cf10 \strokec10 1\cf2 \cb1 \strokec2 \
\cb3     \cf11 \strokec11 End If\cf2 \cb1 \strokec2 \
\pard\pardeftab720\sl380\partightenfactor0
\cf11 \cb3 \strokec11 Else\cf2 \cb1 \strokec2 \
\
\pard\pardeftab720\sl380\partightenfactor0
\cf2 \cb3     \cf11 \strokec11 If\cf2 \strokec2  \cf6 \strokec6 SlopeX\cf2 \strokec2  > \cf10 \strokec10 0\cf2 \strokec2  AND \cf6 \strokec6 SlopeY\cf2 \strokec2  > \cf10 \strokec10 0\cf2 \strokec2  \cf11 \strokec11 Then\cf2 \cb1 \strokec2 \
\cb3     \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "SE"\cf2 \cb1 \strokec2 \
\cb3     \cf6 \strokec6 initialTX\cf2 \strokec2  =\cf6 \strokec6  initialTX\cf2 \strokec2  + \cf10 \strokec10 1\cf2 \cb1 \strokec2 \
\cb3     \cf6 \strokec6 initialTY\cf2 \strokec2  =\cf6 \strokec6  initialTY\cf2 \strokec2  + \cf10 \strokec10 1\cf2 \cb1 \strokec2 \
\cb3     \cf11 \strokec11 End if\cf2 \cb1 \strokec2 \
\
\cb3     \cf11 \strokec11 If\cf2 \strokec2  \cf6 \strokec6 SlopeX\cf2 \strokec2  < \cf10 \strokec10 0\cf2 \strokec2  AND \cf6 \strokec6 SlopeY\cf2 \strokec2  > \cf10 \strokec10 0\cf2 \strokec2  \cf11 \strokec11 Then\cf2 \cb1 \strokec2 \
\cb3     \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "SW"\cf2 \cb1 \strokec2 \
\cb3     \cf6 \strokec6 initialTX\cf2 \strokec2  =\cf6 \strokec6  initialTX\cf2 \strokec2  - \cf10 \strokec10 1\cf2 \cb1 \strokec2 \
\cb3     \cf6 \strokec6 initialTY\cf2 \strokec2  =\cf6 \strokec6  initialTY\cf2 \strokec2  + \cf10 \strokec10 1\cf2 \cb1 \strokec2 \
\cb3     \cf11 \strokec11 End If\cf2 \cb1 \strokec2 \
\
\cb3     \cf11 \strokec11 If\cf2 \strokec2  \cf6 \strokec6 SlopeX\cf2 \strokec2  > \cf10 \strokec10 0\cf2 \strokec2  AND \cf6 \strokec6 SlopeY\cf2 \strokec2  < \cf10 \strokec10 0\cf2 \strokec2  \cf11 \strokec11 Then\cf2 \cb1 \strokec2 \
\cb3     \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "NE"\cf2 \cb1 \strokec2 \
\cb3     \cf6 \strokec6 initialTX\cf2 \strokec2  =\cf6 \strokec6  initialTX\cf2 \strokec2  + \cf10 \strokec10 1\cf2 \cb1 \strokec2 \
\cb3     \cf6 \strokec6 initialTY\cf2 \strokec2  =\cf6 \strokec6  initialTY\cf2 \strokec2  - \cf10 \strokec10 1\cf2 \cb1 \strokec2 \
\cb3     \cf11 \strokec11 End if\cf2 \cb1 \strokec2 \
\
\cb3     \cf11 \strokec11 If\cf2 \strokec2  \cf6 \strokec6 SlopeX\cf2 \strokec2  < \cf10 \strokec10 0\cf2 \strokec2  AND \cf6 \strokec6 SlopeY\cf2 \strokec2  < \cf10 \strokec10 0\cf2 \strokec2  \cf11 \strokec11 Then\cf2 \cb1 \strokec2 \
\cb3         \cf6 \strokec6 direction\cf2 \strokec2  = \cf9 \strokec9 "NW"\cf2 \cb1 \strokec2 \
\cb3         \cf6 \strokec6 initialTX\cf2 \strokec2  =\cf6 \strokec6  initialTX\cf2 \strokec2  - \cf10 \strokec10 1\cf2 \cb1 \strokec2 \
\cb3         \cf6 \strokec6 initialTY\cf2 \strokec2  =\cf6 \strokec6  initialTY\cf2 \strokec2  - \cf10 \strokec10 1\cf2 \cb1 \strokec2 \
\cb3     \cf11 \strokec11 End if\cf2 \cb1 \strokec2 \
\pard\pardeftab720\sl380\partightenfactor0
\cf11 \cb3 \strokec11 End if\cf2 \cb1 \strokec2 \
\cf11 \cb3 \strokec11 End if\cf2 \cb1 \strokec2 \
\
\
\
\
\
\pard\pardeftab720\sl380\partightenfactor0
\cf2 \cb3         \cb1 \
\cb3             \cf4 \strokec4 ' A single line providing the move to be made: N NE E SE S SW W or NW\cf2 \cb1 \strokec2 \
\cb3             Console.\cf8 \strokec8 WriteLine\cf2 \strokec2 (\cf6 \strokec6 direction\cf2 \strokec2 )\cb1 \
\cb3         \cf8 \strokec8 End\cf2 \strokec2  \cf11 \strokec11 While\cf2 \cb1 \strokec2 \
\cb3     \cf5 \strokec5 End Sub\cf2 \cb1 \strokec2 \
\pard\pardeftab720\sl380\partightenfactor0
\cf8 \cb3 \strokec8 End\cf2 \strokec2  Module\cb1 \
}