### Initiating database
1. Execute `ConvStore_DB.sql` to create the database
2. Execute `InsertData.sql` to populate it with data.

### Consistency
1. Default font is `Segoe UI, 12pt, style=Bold`
2. All toolbox items use camelCase (`lblID`, `btnCancel`, etc.)

### Creating App.config locally
1. Create a new file in `ConvStore` called `App.config`
2. Copy and paste this into it
```xml
<configuration>
  <connectionStrings>
    <add name="ConvStoreDB"
		 connectionString="Data Source=DATASOURCEHERE;Initial Catalog=INITIALCATALOGHERE;Integrated Security=True"
		 providerName="System.Data.SqlClient"/>
  </connectionStrings>
</configuration>
```
3. Copy the connection string from `ConvStore_DB`
4. Replace `connectionString="Data Source=DATASOURCEHERE;Initial Catalog=INITIALCATALOGHERE;Integrated Security=True"` with what you copied. Make sure to only include `Data Source`, `Initial Catalog` (if it exists) and `Integrated Security`.

### Dealing with App.config being removed upon pulling from repo
1. Temporarily remove it from `.gitignore`:

Edit ``.gitignore` and comment out the line:
```
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