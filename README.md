 
goldsrc SDK Launcher RC1
====================

Launcher для GoldSource SDK от Hl-Lab.ru


###TODO for KASTHACK:
====================
 
1. Сделать MessageBox с инфой о переводе.
2. Проверить регистрацию файлов с иконками + добавить ассоциацию с wc и rad на notepad.
3. подумать над Global ToDo.
 
###TODO for NEO:
====================
1. Нарисовать иконки.
2. Подправить переводы бел. и исп.

###TODO for STAM:
====================
1. Обновить готовые иконки и лаунчер.
2. Пересобрать инсталл для тестирования.
3. Запилить сплэшскрин. (под вопросом)

####Glogal TODO
====================

1. Запилить обновление компонентов
2. Запилить менеджер конфигураций. Для добавления через него пользовательских программ(путей, url) и иконок к ним в отдельный блок

```xml
<programs>
	<...>
	<category name="custom">
		<app>
			<name>Test app</name>
			<icon>C:/Documents/test app.ico</icon>
			<path>C:/Documents/test app.exe</path>
			<params>-silent</params>
		</app>
	</category>
</programs>	
```
