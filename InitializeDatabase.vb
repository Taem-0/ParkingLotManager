Imports MySql.Data.MySqlClient

Public Class InitializeDatabase

    Shared ConnString As String = "server=localhost;
                                user id=root;
                                password=;"

    Shared ConnString_Table As String = "server=localhost;
                                      user id=root;
                                      password=;
                                      database=parkinglotdb;"

    Public Shared Database_Success As Boolean = False

    Public Shared Sub InitializeTABLE()
        Try

            Using conn As New MySqlConnection(ConnString)
                conn.Open()
                Using cmd As New MySqlCommand("CREATE DATABASE IF NOT EXISTS parkinglotdb;", conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Using conn As New MySqlConnection(ConnString_Table)
                conn.Open()
                Using cmd As New MySqlCommand("
            CREATE TABLE IF NOT EXISTS parkinghistory (
                HistoryID   INT(11) NOT NULL AUTO_INCREMENT,
                SlotID      INT(11) NOT NULL,
                Slot        VARCHAR(10) NOT NULL,
                Floor       INT(11) NOT NULL,
                PlateNumber VARCHAR(50) NOT NULL,
                Owner       VARCHAR(50),
                Entry       DATETIME NOT NULL,
                ExitTime    DATETIME,
                Duration    TIME,
                Fee         DECIMAL(10,2),
                PRIMARY KEY (HistoryID),
                KEY idx_slotID (SlotID)
            )", conn)
                    cmd.ExecuteNonQuery()
                End Using

                Using cmd As New MySqlCommand("
                    CREATE TABLE IF NOT EXISTS parkingslots (
                        ID          INT(11) NOT NULL AUTO_INCREMENT,
                        Slot        VARCHAR(10) NOT NULL,
                        Floor       INT(11) NOT NULL,
                        Status      VARCHAR(20) DEFAULT 'Available',
                        PlateNumber VARCHAR(50),
                        Owner       VARCHAR(50),
                        Entry       DATETIME,
                        PRIMARY KEY (ID)
                    );", conn)
                    cmd.ExecuteNonQuery()
                End Using

                Using cmd As New MySqlCommand("
                        INSERT IGNORE INTO `parkinghistory`
                        (HistoryID, SlotID, Slot, Floor, PlateNumber, Owner, Entry, ExitTime, Duration, Fee)
                        VALUES
                        (2,32,'B8',2,'LM01','Navea, Romelle','2025-09-22 23:57:43','2025-09-23 02:45:06','00:00:00',100.00),
                        (3,1,'A1',1,'ACAB','Taeza, Rex','2025-09-23 02:46:40','2025-09-23 02:46:43','00:00:00',0.00),
                        (4,5,'A5',1,'ULOL','PAKYU','2025-09-23 03:06:11','2025-09-23 03:06:16','00:00:00',0.00),
                        (5,3,'A3',1,'MEOW','posa','2025-09-23 03:04:29','2025-09-23 03:06:18','00:00:00',0.00),
                        (6,1,'A1',1,'Mewo','meh','2025-09-23 03:02:41','2025-09-23 03:06:19','00:00:00',0.00),
                        (7,2,'A2',1,'LAMAW','Me, Rex','2025-09-23 03:01:33','2025-09-23 03:06:21','00:00:00',0.00),
                        (8,1,'A1',1,'WOWOOW','lmao','2025-09-23 03:14:40','2025-09-23 03:14:51','00:00:00',0.00),
                        (9,1,'A1',1,'NUYAAHAHH','RAAAA','2025-09-23 03:21:18','2025-09-23 03:21:21','00:00:00',0.00);", conn)
                    cmd.ExecuteNonQuery()
                End Using

                Using cmd As New MySqlCommand("
                        INSERT IGNORE INTO `parkingslots` 
                        (ID, Slot, Floor, Status, PlateNumber, Owner, Entry) 
                        VALUES
                        (1,'A1',1,'Available',NULL,NULL,NULL),
                        (2,'A2',1,'Available',NULL,NULL,NULL),
                        (3,'A3',1,'Available',NULL,NULL,NULL),
                        (4,'A4',1,'Available',NULL,NULL,NULL),
                        (5,'A5',1,'Available',NULL,NULL,NULL),
                        (6,'A6',1,'Available',NULL,NULL,NULL),
                        (7,'A7',1,'Available',NULL,NULL,NULL),
                        (8,'A8',1,'Available',NULL,NULL,NULL),
                        (9,'B1',1,'Available',NULL,NULL,NULL),
                        (10,'B2',1,'Available',NULL,NULL,NULL),
                        (11,'B3',1,'Available',NULL,NULL,NULL),
                        (12,'B4',1,'Available',NULL,NULL,NULL),
                        (13,'B5',1,'Available',NULL,NULL,NULL),
                        (14,'B6',1,'Available',NULL,NULL,NULL),
                        (15,'B7',1,'Available',NULL,NULL,NULL),
                        (16,'B8',1,'Available',NULL,NULL,NULL),
                        (17,'A1',2,'Available',NULL,NULL,NULL),
                        (18,'A2',2,'Available',NULL,NULL,NULL),
                        (19,'A3',2,'Available',NULL,NULL,NULL),
                        (20,'A4',2,'Available',NULL,NULL,NULL),
                        (21,'A5',2,'Available',NULL,NULL,NULL),
                        (22,'A6',2,'Available',NULL,NULL,NULL),
                        (23,'A7',2,'Available',NULL,NULL,NULL),
                        (24,'A8',2,'Available',NULL,NULL,NULL),
                        (25,'B1',2,'Available',NULL,NULL,NULL),
                        (26,'B2',2,'Available',NULL,NULL,NULL),
                        (27,'B3',2,'Available',NULL,NULL,NULL),
                        (28,'B4',2,'Available',NULL,NULL,NULL),
                        (29,'B5',2,'Available',NULL,NULL,NULL),
                        (30,'B6',2,'Available',NULL,NULL,NULL),
                        (31,'B7',2,'Available',NULL,NULL,NULL),
                        (32,'B8',2,'Available',NULL,NULL,NULL);
                        ", conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using


            Database_Success = True

        Catch ex As Exception
            MessageBox.Show("Error initializing database (DID YOU EVEN OPEN SQL??): " & ex.Message)
        End Try

    End Sub

End Class
