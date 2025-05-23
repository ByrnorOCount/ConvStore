### Initiating database
1. Change project to SqlFileMerger and Start, then change it back to ConvStore
2. Execute `ConvStore_DB.sql` to create the database
3. Execute `Authorization.sql` to create roles
4. Execute `InsertData.sql` to populate it with data
   
Note: You can repeat step 2 and THEN 4 (not step 3) if you want to reset the database.

### Consistency
1. Default font is `Segoe UI, 12pt, style=Bold`
2. All toolbox items use camelCase (`lblID`, `btnCancel`, etc.)

### Making/modifying App.config locally
1. Create ConvStore/App.config
2. Paste in this
```xml
<configuration>
	<connectionStrings>
		<add name="ConvStoreDB"
			 connectionString="Data Source=DATASOURCEHERE;Initial Catalog=INITIALCATALOGHERE;Integrated Security=True"
			 providerName="System.Data.SqlClient"/>
	</connectionStrings>
</configuration>
```
2. Copy the connection string from `ConvStore_DB`
3. Replace `connectionString="Data Source=DATASOURCEHERE;Initial Catalog=INITIALCATALOGHERE;Integrated Security=True"` with what you copied. Make sure to only include `Data Source`, `Initial Catalog` (if it exists) and `Integrated Security`.

### Dealing with App.config being removed upon pulling from repo
1. Temporarily remove it from `.gitignore`:

Edit `.gitignore` and comment out the line:
```bash
#/ConvStore/App.config
```
2. Add the file to the index:
```bash
git add ConvStore/App.config
git commit -m "Add App.config to index (will ignore changes later)"
```
3. Now mark it as unchanged:
```bash
git update-index --assume-unchanged ConvStore/App.config
```
4. Restore the .gitignore line:

Uncomment `/ConvStore/App.config` (remove the #) so it won't be touched in the future.
