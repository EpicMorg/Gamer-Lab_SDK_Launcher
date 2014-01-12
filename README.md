glodsrc SDK Launcher
====================

Launcher для GoldSource SDK от Hl-Lab.ru


TODO for KASTHACK:
====================

Дерево:
./SDK
./SDK/addons
./SDK/addons/<.Подпапки с доп программами.>
./SDK/launcher/
./SDK/launcher/langs
./SDK/launcher/langs/rus.xml
./SDK/launcher/icons
./SDK/launcher/icons/<.иконки ассоциаций.>
./SDK/launcher/logos
./SDK/launcher/logos/<.иконки дял меню.>
./SDK/launcher/config.xml
./SDK/launcher/launcher.exe
./SDK/launcher/list.xml
./SDK/<.Пропущу папки префабов и тд.>
./SDK/hammer.exe


Основной конфиг:
1. Основной конфиг в хранится Config.xml. При его отсутствии - создается с дефолтными параметрами.
2. В нем прописан дефолтный язык. Англ.
3. В меню настроек есть ассоциация некоторых файлов. При запуске лаунчера сканируется реестр с этими расширениями
и сверяется с блоком в этом конфиге. Если расширение не зарегано на компе - то в вып. списке отображается none.
3.1. Если расширение разегистрировано с программой не из SDK - то пишется - Other.
3.2. Вып. список для каждого расширения фомируется из программ, которые установлены (смотрится list.xml с пометкой true) у которых есть соответствующая <extensions>. Например если у хаммера 
<extensions>
	<ext>rmf</ext>
	<ext>map</ext>
</extensions>, то он будет в списке ассоциаций у RMF и у MAP.


Язык:
1. По умолчанию сделан язык англ. Будет сделан русский в xml.
2. При каждом открытии запуске лаунчера сканируется папка langs на наличие изменений. Список либо пополняется либо убывает.
3. При удалении внешнего языка лаунчера(берется из конфига) - заменяется на англ в Config.xml обратно.


Кофиг list.xml:
1. Вся инфа о спике установленных программ, хранится в list.xml, которые сформирован нами заранее.
1.1 Пути относительные. Для совестимости. относительно папки SDK(см. выше).
2. Меню формируется из этого конфиг файла. В котором у каждой проги написано: ее название, относительный путь дял запуска и относительный путь для иконки в меню и стоит триггер <installed>, который по умолчанию идет False.
3. лаунчер(при первом запуске) сканирует указанные дирректории на наличие этих программ и от этого отталкиваясь пишет конфиг к каждой найденной программе true в блок <installed>.
4. Если добавлена программа или удалена, то для переформирования списка можно нажать соответствующую кнопку в меню настроек.
5. Блок программ разделен на категории: маппинг, управление контентом, компиляция\декомпиляция, модостроение, моделирование, текстурирование, помощь(мануалы):

пример:

<programs>
	<category name="Mapping"> 
		<app>	 
			<name>Hammer 3.5</name>
			<icon>./SDK/Launcher/logos/hammer.png(ico)</icon>
			<path>./SDK/hammer.exe</path> 
			<extensions>
				<ext>rmf</ext>
				<ext>map</ext>
			</extensions>
			<installed>true</installed>
		</app>
		<app> 
			<name>Hammer 3.5 Neon</name>
			<icon>./SDK/Launcher/logos/hammer_neon.png(ico)</icon>
			<path>./SDK/neon.exe</path>
			<allow_associate_with>rmf, map</associate_with>
			<installed>false</installed>
		</app>
	</cate>
	<...>
	<category name="Texturing">
		<app>	
			<name>Wally 1.55b</name>
			<icon>./SDK/Launcher/logos/wally.png(ico)</icon>
			<path>./SDK/addons/wally/wally.exe</path>
			<allow_associate_with>pak, wad</associate_with>
			<installed>true</installed>
		</app>
	</texturing>
	<...>
</programs>



