﻿CREATE USER [ILR1819DataStore_RO_User]
    WITH PASSWORD = N'$(ROUserPassword)';
GO

GRANT CONNECT TO [ILR1819DataStore_RO_User]

GO
