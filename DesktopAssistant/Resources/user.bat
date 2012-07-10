	@echo off
	
	SQLCMD -E -S .\SQLEXPRESS -d Nestle -Q "UPDATE tUserSettings SET PropertyValue = '' where PropertyName = 'People_ID'; UPDATE tUserSettings SET PropertyValue = '%1' where PropertyName = 'UserName'; UPDATE tUserSettings SET PropertyValue = '%2' where PropertyName = 'Password'"
	echo UserName is set to: %1
	echo Password is set to: %2
	echo Truncating tables: tTimeCapture, tStoreNew, tPersonalEvent, tNHMComment, tDBSSNotPresent, tDBSSNotPresentDeleted, tSyncConfig, tSyncLog, tItem
	SQLCMD -E -S .\SQLEXPRESS -d Nestle -Q "truncate table tTimeCapture; truncate table tStoreNew; truncate table tPersonalEvent; truncate table tNHMComment; truncate table tDBSSNotPresent; truncate table tDBSSNotPresentDeleted; truncate table tSyncConfig; truncate table tSyncLog; delete from tItem"