   M S B A M L   `   `   `  ����B  >CPSC481, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CPSC481CPSC481  5   	       CPSC481.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CPSC481     5   	     � Title$  
MainWindow��5   	   $	��800��6   $
��1260��6)   .��5
      � -   5         �Name$ 
everything��5
   /   $��0,0,0,0q�6   
������� � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   � -   5        $ Overlay��5       J� Opacity$
 0.75Q�6     5      �� 5      $
��412* �6    �� 5      $
��359* �6    .+�5      (�  (� Stretch$ Uniform=�6   $��2��6(   .��5      �� $
��Left=�6   $	��800��67   $	��Top=�6D   $
��1260��6\   $��0,0,0,0q�6i   ��5      ��5      	LightGray��6+   5      5      �� 5      -   5         ��Name$ overlayRect��5      $��2��6-   
���   �5!      � 5"      -   5        $ 	prefTable��5"   �   $��194,386,193.6,153.4q�6   $��2��60   $��Center=�6A   .+�5#      �� $��Outdoor Cooking��6   $
��Left=�62   $��37��6M   $	��Top=�6Y   $	��197��6q   
�������$��RightToLeft=�6�   $��Center=�6�   $
��Bold"�6�   $��20(�6�   $��669,0,-0.4,0q�6�   �� 5$      -   5        $��Steak��5$      $
��Left=�6(   $��36��6C   $	��Top=�6O   $��16(�6g   $��Center=�6u   
�������$	��155��6�   $��
692,42,0,0q�6�   6�   �� 5%      -   5        $��Barbeque��5%      $
��Left=�6+   $��36��6F   $	��Top=�6R   $��16(�6j   $��Center=�6x   
�������$	��155��6�   $��
692,78,0,0q�6�   6�   �� 5&      -   5        $��Burgers��5&      $
��Left=�6*   $��36��6E   $	��Top=�6Q   $��16(�6i   $��Center=�6w   
�������$	��155��6�   $��692,119,0,0q�6�   6�   �� 5'      $��Dietary��6   $
��Left=�6*   $��37��6E   $��	16,-2,0,0q�6Q   $	��Top=�6d   $	��197��6|   
�������$��RightToLeft=�6�   $��Center=�6�   $
��Bold"�6�   $��20(�6�   �� 5(      -   5        $��Gluten Free��5(      $
��Left=�6.   $��36��6I   $	��Top=�6U   $��16(�6m   $��Center=�6{   
�������$	��155��6�   $��	40,40,0,0q�6�   6�   �� 5)      -	   5        $��Vegan��5)      $
��Left=�6(   $��36��6C   $	��Top=�6O   $��16(�6g   $��Center=�6u   
�������$	��155��6�   $��	40,76,0,0q�6�   6�   �� 5*      -
   5        $��
Vegetarian��5*      $
��Left=�6-   $��36��6H   $	��Top=�6T   $��16(�6l   $��Center=�6z   
�������$	��155��6�   $��
40,117,0,0q�6�   6�   �� 5+      $��Cuisine��6   $
��Left=�6*   $��37��6E   $��	449,0,0,0q�6Q   $	��Top=�6d   $	��197��6|   
�������$��RightToLeft=�6�   $��Center=�6�   $
��Bold"�6�   $��20(�6�   �� 5,      -   5        $��Italian��5,      $
��Left=�6*   $��36��6E   $	��Top=�6Q   $��16(�6i   $��Center=�6w   
�������$	��155��6�   $��
473,42,0,0q�6�   6�   �� 5-      -   5        $��French��5-      $
��Left=�6)   $��36��6D   $	��Top=�6P   $��16(�6h   $��Center=�6v   
�������$	��155��6�   $��
473,78,0,0q�6�   6�   �� 5.      -   5        $��Medittereanean��5.      $
��Left=�61   $��36��6L   $	��Top=�6X   $��16(�6p   $��Center=�6~   
�������$	��155��6�   $��473,119,0,0q�6�   6�   �� 5/      $��Cooking Styles��6   $
��Left=�61   $��37��6L   $��	231,0,0,0q�6X   $	��Top=�6k   $	��197��6�   
�������$��RightToLeft=�6�   $��Center=�6�   $
��Bold"�6�   $��20(�6�   �� 50      -   5        $��Baking��50      $
��Left=�6)   $��36��6D   $	��Top=�6P   $��16(�6h   $��Center=�6v   
�������$	��155��6�   $��
255,42,0,0q�6�   6�   �� 51      -   5        $��Frying��51      $
��Left=�6)   $��36��6D   $	��Top=�6P   $��14(�6h   $��Center=�6v   
�������$	��155��6�   $��
255,78,0,0q�6�   6�   �� 52      -   5        $��Slow Cooking��52      $
��Left=�6/   $��36��6J   $	��Top=�6V   $	��155��6n   $��14(�6z   $��Center=�6�   
�������$��255,119,0,0q�6�   6�   �� 53      -   5        $��Clear��53      $��Center=�6)   $��373,191,370.6,0q�6F   $	��Top=�6_   $	��122��6w    J� RenderTransformOrigin$ 0.096,-0.421&�6�   $��30��6�   6�   �� 54      -   5        $��Save Preferences��54      $��Center=�64   $��265,191,478.6,0q�6Q   $	��Top=�6j   $	��122��6�   $ 0.096,-0.421&�6�   $��30��6�   ���	#FF45FA006�   �� 55      -   5        $��Cancel��55      $��Center=�6*   $��482,191,261.6,0q�6G   $	��Top=�6`   $	��122��6x   $ 0.096,-0.421&�6�   $��30��6�   
���  ��
�������6�   56      �� 57      -   5         ��Name$ 
prefHeader��57   �   $F��@Click and choose your Cooking Preferences to Tailor your results��6   $��Center=�6_   $��54��6|   $��	0,169,0,0q�6�   $	��Top=�6�   $	��705��6�   $��24(�6�   ���	#FFFFF6F66�   59      � 5:   
   -   5        $
 grid��5:      $	��141��6   $	��Top=�6*   $��87,10,106.6,0q�6B   $��Center=�6Y   $
��1060��6v   .+�5;      �� $�� ��6   $	��Top=�6   $��
0,109,10,0q�67   $��32��6K   ���	#FFA67272$��0,0,0,1q�6o   $��24(�6�   $��Right=�6�   $
��1040��6�   �� 5<      $��BUDGET BITES
��6   $��86.24��60   $��41.6,0,210.4,0q�6?   $	��Top=�6W   $ 0.502,0.483&�6o   $��72(�6�   $��Center=�6�   $��Microsoft YaHei UI Light)�6�   $��RightToLeft=�6�   $��Disabled=�6  $��Right=�6O  $��0q�6r  ���	#FFA67272$��911.1��6�  ��6�   Z� 6�  �� 5=      $��Frugality is our passion��6   $
��Left=�67   $	��Top=�6R   $��213.816,86.24,0,0q�6j   $��39.293��6�   $��731.994��6�   $��0,0,0,1q�6�   $��20(�6�   $	 0.4Q�6�   5>      � 5?   
   $��59,534,330.6,73q�6   .+�5@      �� $!��Browse Different Categories��6   $��Center=�6:   $��44��6W   $��
38,0,337,0q�6c   $	��Top=�6w   $	��489��6�   $��Trebuchet MS)�6�   $��26(�6�   $��0,0,0,1q�6�   ���	#FFA67272$
��Bold"�6�   � 5A      $��199,64,-129,-32.6q�6   $��Center=�6.   $��Center=�6K   $	��132��6f   $	��794��6s    5B      �� 5C      $��656.474 �6'   .+�5E      A� $��202,28,336.6,0q�6   $ 2.084,0.895&�62   ��5F      �� 5G      	 �� ImageSource$	 p3_burned.png��6%   5I      �� 5J      $��Dinner��6   $
��Left=�6)   $��413.164,0,0,0q�6D   $	��Top=�6[   $��101.601��6s   $��Center=�6�   $��38.342��6�   $��18(�6�   $
��Bold"�6�   �� 5K      $��Lunch��6   $��Center=�6(   $��211.697,0,343.177,0q�6E   $	��Top=�6b   $��101.6��6z   $��Center=�6�   $��38.342��6�   $��18(�6�   $
��Bold"�6�   �� 5L      $��	Breakfast��6   $��Center=�6,   $��21.05,0,533.824,0q�6I   $	��Top=�6d   $��101.6��6|   $��Center=�6�   $��38.342��6�   $��18(�6�   $��Disabled=�6�   $
��Bold"�6   �� 5M      $��Dessert��6   $��Center=�6*   $��608,-2,-52.4,0q�6G   $	��Top=�6_   $	��102��6w   $��Center=�6�   $��38��6�   $��18(�6�   $
��Bold"�6�   A� 5N      ���	#FF898989���	#FFFFFBFB$��0��6>   $��85.338��6R   $��Center=�6b   $��413.164,38.342,141.709,0q�6}   $��101.601��6�   A� 5O      $��10,28,526.6,0q�6   $ 2.084,0.895&�61   ��5P      �� 5Q      $	 p4_burned.png��6%   5S      A� 5T      $��407,28,136.6,0q�6   $ 2.084,0.895&�62   ��5U      �� 5V      $	 p1.png��6%   5X      A� 5Y      $��596,22,-75.4,0q�6   $ 2.084,0.895&�62   ��5Z      �� 5[      $	 p2_burned.png��6%   5]      � 5^      -   5        $��400,32,136.6,0q�5^      .+�5_      �� -   5        $��Button��5_      $
��Left=�6.   $	��100��6I   $	��Top=�6V   $	��121��6n   $ 0Q�6z   6�   5`      � 5a      -   5        $��202,32,334.6,0q�5a      .+�5b      �� -   5        $
��Left=�5b      $	��100��68   $	��Top=�6E   $	��121��6]   $ 0Q�6i   6u   5c      � 5d      -   5        $��596,32,-59.4,0q�5d      .+�5e      �� -   5        $��Button��5e      $
��Left=�6.   $	��100��6I   $	��Top=�6V   $	��121��6n   $ 0Q�6z   6�   5f      � 5g      -   5        $��10,32,526.6,0q�5g      .+�5h      �� -   5        $��Button��5h      $
��Left=�6.   $	��100��6I   $	��Top=�6V   $	��121��6n   $ 0Q�6z   6�   5i      5j      5k      � 5l   
   $��200,226,73.6,386.4q�6   $��980.147��6+    5m      �� 5n      $	��91* �6#   �� 5o      $	��97* �6#   �� 5p      $	��57* �6#   .+�5r      �� -   5        $��Cooking Preferences��5r      $��Center=�63   $��34��6P   $��	2,10,79,0q�6\      SimpleButton#���   6o   $	��Top=�6�   $	��147��6�   $��Segoe UI Semilight)�6�   $��2��6�   ��5t      �� 5u      
 �� EndPoint$	
 0,1&�6*    �� 
StartPoint$	 0,0&�69   .��5v      �  � Color$ 	#FFCCCCCC��6'    � Offset$ 0Q�69   � 5w      $ 	#FFA67272��6'   $ 1Q�69   5x      ��5z      �� 5{      $	
 0,1&�6*   $	 0,0&�69   .��5|      � $ 	#FFEEEEEE��6'   $ 0Q�69   � 5}      $ 	#FFA67272��6'   $ 1Q�69   5~      5�      �� 5�      ���	#FF898181$	��1.5q�6-   $
��Left=�6C   $��57��6^   $	��Top=�6j   $	��727��6�    �� CornerRadius$ 15��6�   $��2��6�   
�������._�5�      � .+�5�      �� -   5         ��Name$ SearchTermTextBox��5�   3   $
��Left=�5�      $
��36.4��69    �� TextWrapping$
 Wrap=�6G   $	��Top=�6[   $��706.888��6s    �� TextAlignment$ Center=�5�      $��Center=�6(   $��Center=�6J    � UseLayoutRounding .  $��0q�5�      }�. $��24(�69   4  .System.Windows.Automation.AutomationProperties   Name$ Search��6G   $��8.5,8.5,0,0q�5�      $ 1Q�6'   63   �� 5�       J� IsHitTestVisible .  $L��FType your Recipe, or some keywords and let us do the searching for you��69   $��20(�6�   $��Center=�6�   $��Center=�6�   $��10,0,0,0q�6�   
���������5�      �� 5�       �� 
TargetType" ��6$   .�5�   "   ��  �� Property � y� �� Value$ 	Collapsed=�6?    �� Triggers 5�   "   �� 5�   &    �� Binding 62   �� *Text+ �� ElementName$ SearchTermTextBox�� �� Value  6j   .a�5�   *   ��  � y�$ Visible=�6G   5�   '   5�      5�      5�      5�      �� 5�      -    5        $��Show me a random recipe��5�      $��Center=�67   $��45��6T   $��
87,98,80,0q�6`   #���   6t   $	��Top=�6�   $	��221��6�   $��Segoe UI Semilight)�6�   $
��18px(�6�   $��1��6�   ��5�      �� 5�      $	
 0,1&�6*   $	 0,0&�69   .��5�      � $ 	#FFEEEEEE��6'   $ 0Q�69   � 5�      $ 	#FFADA6A6��6'   $ 1Q�69   5�      5�      �� 5�      -!   5        $��Search��5�      $��Center=�6&   $��45��6C   $��
68,98,75,0q�6O   #���   6c   $	��Top=�6�   $	��221��6�   $��Segoe UI Semilight)�6�   $
��30px(�6�   ��5�      �� 5�      $	
 0,1&�6*   $	 0,0&�69   .��5�      � $ 	#FFEEEEEE��6'   $ 0Q�69   � 5�      $ 	#FFADA6A6��6'   $ 1Q�69   5�      5�      5�      5�      5�      