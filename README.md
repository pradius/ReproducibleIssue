# ReproducibleIssue

Issue in Blazor in which some data is passed down a few times. When I click in some action button to open a Modal, the Oninitialized method gets called again and the data that was passed down is not available in the component annymore raising a Null Exception.
