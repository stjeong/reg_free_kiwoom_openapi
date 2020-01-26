
FOR /F %%I IN ("%0") DO SET CURRENTDIR=%%~dpI
tlbimp %CURRENTDIR%..\Lib\KHOpenAPI.ocx /out:Interop.KHOpenAPILib.dll /namespace:KHOpenAPILib