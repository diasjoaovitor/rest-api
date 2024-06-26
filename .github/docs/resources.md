## Database

```sql
CREATE TABLE IF NOT EXISTS person (
  id INT NOT NULL AUTO_INCREMENT,
  address varchar(100) NOT NULL,
  name varchar(80) NOT NULL,
  gender varchar(6) NOT NULL,
  PRIMARY KEY (id)
);
```
