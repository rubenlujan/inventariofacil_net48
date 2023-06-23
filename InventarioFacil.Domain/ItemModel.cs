using InventarioFacil.Common;
using InventarioFacil.DAL.DBServices;
using InventarioFacil.DAL.DBServices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;


namespace InventarioFacil.Domain
{
    public class ItemModel
    {
        private ItemsDA _itemsDal;

        public ItemModel()
        {
            _itemsDal = new ItemsDA();
        }

        public List<Item> GetItemList()
        {
            List<Item> list = new List<Item>();
            list = _itemsDal.GetItemList();
            return list;
        }

        public Item GetItem(int id)
        {
            return _itemsDal.GetItem(id);
        }

        public OperationResult SetItemImage(int itemId, byte[] image)
        {
            OperationResult result = new OperationResult();
            result = _itemsDal.SetItemImage(itemId, image);
            return result;
        }
    }
}
