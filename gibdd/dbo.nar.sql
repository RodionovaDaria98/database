CREATE TABLE [dbo].[nar] (
    [Статья]      NCHAR (10)    NOT NULL,
    [Наим_наруш]  NVARCHAR (50) NOT NULL,
    [Сумма(мин)]  NCHAR (10)    NOT NULL,
    [Сумма(макс)] NCHAR (10)    NOT NULL,
    [Скорость(мин)] NCHAR(10) NULL, 
    [Скорость(макс)] NCHAR(10) NULL, 
    [Фиксация камерой] NCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([Статья] ASC)
);

