   M S B A M L   `   `   `  ????G  CDietalicious, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DietaliciousDietalicious  5   	       Dietalicious.Settings   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Dietalicious     5   	     ? Title$  Settings??5   	   $	??450??6   $	??800??6'   .??5	      ? ???	#FF133A1B$??0,1,0,-1q?6"    ? RowDefinitions 5
   
   ?? 5      $	??53* ?6   ?? 5      $
??381* ?6   .+?5   
   ?? $??Center=?6   $??87??61   
???   ?$	??Top=?6L   $	??800??6d   ???	#FFE4DEAE$??0,-4,0,0q?6?   $??2??6?   ?? 5   
   -   5         ??Name$ lblSettingsTitle??5      $??Settings??6*   $
??Left=?6=   $??	35,19,0,0q?6X   $	??Top=?6k   ???	#FF1E1E1E$??Inter Extrabold)?6?   $??32(?6?   $??2??6?   5      ?? 5   
   -   5        $ lblUsn??5      $??Username??6    $
??Left=?63   $??	82,60,0,0q?6N   $	??Top=?6a   ???	#FFB7BF96$??Inter Medium)?6?   $??20(?6?   $??37??6?   $??1??6?   ?? 5   
   -   5        $ lblName??5      $
??Name??6!   $
??Left=?60   $??
82,107,0,0q?6K   $	??Top=?6_   ???	#FFB7BF96$??Inter Medium)?6?   $??20(?6?   $??37??6?   $??1??6?   ?? 5   
   -   5        $ lblEmail??5      $??Email??6"   $
??Left=?62   $??82,152,0,192q?6M   ???	#FFB7BF96$??Inter Medium)?6z   $??20(?6?   $??1??6?   ?? 5   
   -   5        $ lblPassword??5      $??Change password??6%   $
??Left=?6?   $??
82,199,0,0q?6Z   $	??Top=?6n   ???	#FFB7BF96$??Inter Medium)?6?   $??20(?6?   $??37??6?   $??1??6?   ?? 5   
   -   5        $ lblBMI??5      $	??BMI??6    $
??Left=?6.   $??
82,240,0,0q?6I   $	??Top=?6]   ???	#FFB7BF96$??Inter Medium)?6?   $??20(?6?   $??37??6?   $??1??6?   ?? 5   
   -   5         ??Name$ tbEmail??5      $
??Left=?6#   $??347,158,0,0q?6>    ?? TextWrapping$
 Wrap=?6S   $?? ??6g   $	??Top=?6o   $	??355??6?   $??27??6?   $??Inter Regular)?6?   $??18(?6?   $??1??6?   G? 5   
   -   5         G?Name$ tbPass??5      $
??Left=?6&   $??347,204,0,0q?6A   $	??Top=?6V   $	??355??6n   $??27??6z   $??Inter Regular)?6?   $??18(?6?    G? 	MaxLength$ 15??6?    G? PasswordChar$ *??6?   $??1??6?   ?? 5   
   -	   5        $ tbBMI??5      $
??Left=?6!   $??347,251,0,0q?6<   $
 Wrap=?6Q   $?? ??6e   $	??Top=?6m   $	??355??6?   $??27??6?   $??Inter Regular)?6?   $??18(?6?   $??1??6?   ?? 5   
   -
   5        $ tbName??5      $
??Left=?6"   $??347,112,0,0q?6=   $
 Wrap=?6R   $?? ??6f   $	??Top=?6n   $	??355??6?   $??27??6?   $??Inter Regular)?6?   $??18(?6?   $??1??6?   ?? 5   
   -   5        $ tbUsn??5      $
??Left=?6!   $??
347,65,0,0q?6<   $
 Wrap=?6P   $?? ??6d   $	??Top=?6l   $	??355??6?   $??27??6?   $??Inter Regular)?6?   $??18(?6?   $??1??6?   ?? 5   
   -   5         ??Name$ btnSave??5      $
??Save??6"   $
??Left=?61   $??173,315,0,28q?6L   ???	#FFE4DEAE???	#FF011B10$??
Inter Bold)?6?   $	??152??6?   $??15(?6?   $??2,2,2,2q?6?   $??Center=?6?   $??Center=?6  $??1??65  	 ? 	Resources	 5      
 ?? 
TargetType ?? Property ?? Value??%_   '??       ?? 5      "
 ??6   .?5      ??  ?@??CornerRadius$ 20??65   5       5!      ??5"      ?? 5#       ?? Color$ 	#FF011B10??6"    ?? Opacity$ 0Q?64   5%      ?? 5&   
   -   5        $ 	btnCancel??5&      $??Cancel??6$   $??476,315,173,28q?65   ???	#FFE4DEAE???	#FF011B10$??
Inter Bold)?6?   $??15(?6?   $??2,2,2,2q?6?   $??Center=?6?   $??Center=?6?   $??1??6  	 5'      ??%_   '??       ?? 5(      "
 ??6   .?5)      ??  ?@??CornerRadius$ 20??65   5*      5+      ??5,      ?? 5-      $ 	#FF011B10??6"   $ 0Q?64   5/      ?? 50   
   -   5        $ btnFav??50      $??Favorite recipes??6!   $
??Left=?6<   $??
569,24,0,0q?6W   $	??Top=?6k   ???	#FF011B10???	#FFB7BF96$??
Inter Bold)?6?   $??38??6?   $	??207??6?   $??15(?6?   $??2,2,2,2q?6  $??2??6   	 51      ??%_   '??       ?? 52      "
 ??6   .?53      ??  ?@??CornerRadius$ 20??65   54      55      ??56      ?? 57      $ 	#FF011B10??6"   $ 0Q?64   59      5;      5<      