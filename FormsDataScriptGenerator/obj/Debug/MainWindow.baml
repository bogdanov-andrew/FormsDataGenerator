   M S B A M L   `   `   `  ����S  OFormsDataScriptGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:FormsDataScriptGeneratorFormsDataScriptGenerator  5   	   )    #FormsDataScriptGenerator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   KformsDataScriptGenerator&clr-namespace:FormsDataScriptGenerator     5   	     � Title$  
MainWindow��5   	   $	��519��6   $	��900��6)   .��5      � -   5         �Name$
 grid��5       � ColumnDefinitions 5   
   �� 5      $��9* �6   �� 5	      $
��883* �6   .+�5   
   �� -   5         ��Name$
 list��5   U   $��	2,37,0,37q�6   $��1��6&   $
��Left=�6�   $	��586��6�   ��66   �� *Fields+ �� SelectedItem 6c   �� *SelectedField+ �� Mode$ TwoWay=���5      �� 5      .R�5      � .+�5      �� $��Title: ��6$   �� 5      $
��Bold"�6;   ��6$   �� *Title+6;   �� 5      $��Key: ��6$   �� 5      $
��Bold"�69   ��6$   �� *Key+69   �� 5      $��
LookupId: ��6$   �� 5      $
��Bold"�6>   ��6$   �� *
LookupId+6>   �� 5      $��FieldType: ��6$   �� 5      ��6$   �� *FieldType.Name+5      5      5      �� 5   
   $��Generate��6   $��	0,0,13,10q�6H   $��1��6[   $��Right=�6k   $��75��6�   $��22��6�   $��Bottom=�6�   ��6$   �� *GenerateCommand+6�   �� 5   
   $��1��6   $
��Left=�6q   $��87��6�   $��619,154,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��254��6�    � DataContext 6"   �� *SelectedField+��6H   ��  �� Path$ Title�$ TwoWay=�6�   �� 5   
   	 �� DisplayMemberPath$
	 Name��6;   
 �� SelectedValuePath$
 	FieldType��6T   $��1��6�   $
��Left=�6�   $��619,397,0,0q�6�   $	��Top=�6�   $	��120��6  ��6   �� $ 
FieldTypes� 6r   �� $ SelectedField.FieldType�$ TwoWay=�6  �� 5    
   $��Title��6   $��1��6    $
��Left=�60   $��619,123,0,0q�6K   $	��Top=�6`    J� RenderTransformOrigin$ 0.386,0.551&�6x   �� 5!   
   $��1��6   $
��Left=�6H   $��24��6c   $��619,277,0,0q�6o   $
 Wrap=�6�   $	��Top=�6�   $	��254��6�    6"   �� *SelectedField+.��6�   ��5"      �� 5#      $	 Key�6   $ TwoWay=�6%    �� UpdateSourceTrigger$ 	LostFocus=�63    �� ValidationRules 5$      3   -FormsDataScriptGenerator.LengthValidationRule  5%      6J   5'      .��5(      5)      �� 5*   
   $��FormFieldDefinitionKey��6   $��1��61   $
��Left=�6A   $��619,246,0,0q�6\   $	��Top=�6q   $ 0.386,0.551&�6�   �� 5+   
   $��1��6   $
��Left=�6H   $��24��6c   $��619,337,0,0q�6o   $
 Wrap=�6�   $	��Top=�6�   $	��254��6�    6"   �� *SelectedField+.��6�   ��5,      �� 5-      $ LookupId�6   $ TwoWay=�6*   $ 	LostFocus=�68    5.      1   +FormsDataScriptGenerator.GuidValidationRule  5/      6H   51      .��52      53      �� 54   
   $��LookupTypeId (GUID)��6   $��1��6.   $
��Left=�6>   $��619,306,0,0q�6Y   $	��Top=�6n   $ 0.386,0.551&�6�   �� 55   
   $��
Field Type��6   $��1��6%   $
��Left=�65   $��619,366,0,0q�6P   $	��Top=�6e   $ 0.386,0.551&�6}   �� 56   
   $	��New��6   $��1��6>   $
��Left=�6N   $��619,430,0,0q�6i   $	��Top=�6~   $��75��6�   ��6   �� *
NewCommand+6�   �� 58   
   $��FormDefinitionId (GUID)��6   $��1��62   $
��Left=�6B   $��	619,5,0,0q�6]   $	��Top=�6p   $ 0.386,0.551&�6�   �� 59   
   $��1��6   $
��Left=�6"   $��24��6=   $��
619,37,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��254��6�   .��6�   ��5:      �� 5;      $ FormID�6   $ TwoWay=�6(   $ 	LostFocus=�66    5<        5=      6H   5?      .��5@      5A      �� 5C   
   $"��FormFieldDefinitionId (GUID)��6   $��1��67   $
��Left=�6G   $��
619,67,0,0q�6b   $	��Top=�6v   $ 0.386,0.551&�6�   �� 5D   
   $��1��6   $
��Left=�6H   $��24��6c   $��
619,99,0,0q�6o   $
 Wrap=�6�   $	��Top=�6�   $	��254��6�    6"   �� *SelectedField+.��6�   ��5E      �� 5F      $ Id�6   $ TwoWay=�6$   $ 	LostFocus=�62    5G        5H      6H   5J      .��5K      5L      �� 5M   
   $��Remove��6   $��1��6"   $
��Left=�6T   $��707,430,0,0q�6o   $	��Top=�6�   $��75��6�   ��62   �� *RemoveCommand+6�   �� 5N   
   $
��Load��6   $��1��6    $
��Left=�6P   $��	10,10,0,0q�6k   $	��Top=�6~   $��74��6�   ��60   �� *LoadCommand+6�   �� 5O   
   $
��Save��6   $��1��6    $
��Left=�6P   $��
105,10,0,0q�6k   $	��Top=�6   $��76��6�   ��60   �� *SaveCommand+6�   5R      5S      