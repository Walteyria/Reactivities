<script lang="ts">
    import {Navbar, NavbarBrand, NavItem, Button, Nav, NavLink} from 'sveltestrap';
</script>

<Navbar dark color="primary" expand="md" fixed="top">
    <a href="/" >
        <img height="32" src="/logo.png" alt="logo"/>
        <NavbarBrand>Reactivities</NavbarBrand>
    </a>
    <Nav>
        <NavItem>
            <NavLink class="text-white" href="/">Activities</NavLink>
        </NavItem>
        <NavItem>
            <Button outline color="success">Create Activity</Button>
        </NavItem>
    </Nav>
</Navbar>

<style>
    img{
        margin-right: 10px;
    }
</style>