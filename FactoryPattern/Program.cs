using Domain;

PizzaStore nyPizzaStore = new NYStylePizzaStore();
nyPizzaStore.OrderPizza("cheese");

PizzaStore chicagoStylePizzaStore = new ChicagoStylePizzaStore();
chicagoStylePizzaStore.OrderPizza("cheese");
