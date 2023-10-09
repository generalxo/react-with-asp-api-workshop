import React, { useState, useEffect } from 'react';

const ExampleItem = () => {

    const [items, setItems] = useState([]);
    const dataType = 1;

    useEffect(() => {
        fetch(`item/${dataType}`)
            .then((results) => {
                return results.json();
            })
            .then((data) => {
                setItems(data);
            });

    }, []);

    return (
        <main>
            {
                (items.length > 0) ? items.map((item, index) => <h3 key={index}>{item.name}</h3>):<div>Loading...</div>
            }
        </main>
    );

}

export default ExampleItem;