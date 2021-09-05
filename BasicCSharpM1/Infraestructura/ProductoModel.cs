using Domainzzz;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura
{
    public class ProductoModel
    {
        private Producto[] productos;

        public ProductoModel () { }

        public void AddProduct(Producto producto)
        {
            if(producto == null)
            {
                throw new ArgumentException("Error, producto no puede ser null.");
            }
            if (productos == null)
            {
                productos = new Producto[1];
                productos[0] = producto;
                return;
            }
            Producto[] tmp = new Producto[productos.Length + 1];
            Array.Copy(productos, tmp, productos.Length);
            tmp[tmp.Length - 1] = producto;
            productos = tmp;

        }

        public bool Update (Producto p)
        {
            bool success = false;
            int index = GetIndex(p);
            if(index < 0)
            {
                throw new ArgumentException($"Error, producto con codigo {p.Id} no existe.");
            }
            productos [index] = p;
            return !success;
        }

        public int GetIndex(Producto p)
        {
            int index = -1;
            for(int i = 0; i < productos.Length; i++)
            {
                if(productos[i].Id == p.Id)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public bool Delete(Producto p)
        {
            bool flag = false;
            int index = GetIndex(p);
            if(index < 0)
            {
                return flag;
            }

            Producto[] tmp = new Producto[productos.Length - 1];
            productos[index] = productos[productos.Length - 1];
            Array.Copy(productos, tmp, productos.Length - 1);
            productos = tmp;

            return flag;
        }

        public Producto FindById(int id)
        {
            int index = -1;
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i].Id == id)
                {
                    index = i;
                    break;
                }
            }

            return index < 0 ? null : productos[index];

        }

        public Producto[] GetProductosByUnidadMedida()
        {

        }

        public Producto[] GetProductosByCaducity(DateTime dt)
        {

        }

        public Producto[] GetProductosByRangoPrecio(decimal p1, decimal p2)
        {

            int n = 1;
            Producto[] PRangoPrecio = new Producto[n];
            int i = 0;
            foreach (Producto p in productos)
            {
                while (i < productos.Length)
                {
                    if (p.Price > p1 || p.Price < p2)
                    {
                        PRangoPrecio[i] = productos[i];
                        n++;
                    }
                    i++;
                }
            }
            return PRangoPrecio;
        }

        public Producto[] OrdenarByPrecio()
        {
            //if (productos == null)
            //{
            //    return throw new ArgumentException("Error, los objetos no pueden ser null"); ;
            //}
            Array.Sort(productos, ProductoPrecioComparer);
            return productos;
        }

        private int ProductoPrecioComparer(Producto p1, Producto p2)
        {
            if (p1 == null || p2 == null)
            {
                throw new ArgumentException("Error, los objetos no pueden ser null");
            }
            if (p1.Price > p2.Price)
            {
                return 1;
            }
            else if (p1.Price < p2.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public string GetProductosAsJson(Producto[] ps)
        {
            string[] JsonProduct = JsonConvert.SerializeObject(ps);
            return JsonProduct;
        }

    }
}
